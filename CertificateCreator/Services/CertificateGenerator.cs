using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using CertificateCreator.Domain;
using CertificateManager;
using CertificateManager.Models;

namespace CertificateCreator.Services
{
    public class CertificateGenerator : ICertificateGenerator
    {
        private readonly CreateCertificatesClientServerAuth _certificatesClientServerAuth;
        private readonly CreateCertificates _certificateCreator;
        private readonly ImportExportCertificate _importExportCertificate;

        public CertificateGenerator(
            CreateCertificatesClientServerAuth certificatesClientServerAuth,
            CreateCertificates certificateCreator,
            ImportExportCertificate importExportCertificate)
        {
            _certificatesClientServerAuth = certificatesClientServerAuth;
            _certificateCreator = certificateCreator;
            _importExportCertificate = importExportCertificate;
        }

        public (X509Certificate2 x509Certificate2, byte[] certificateBytes, byte[] publicKeyBytes) CreateRootCertificate(CertificateDetailsDto dto)
        {
            var rootCertificate = _certificatesClientServerAuth.NewRootCertificate(
                new DistinguishedName { CommonName = dto.CommonNameText, Country = dto.CountryText },
                new ValidityPeriod
                {
                    ValidFrom = dto.ValidFrom,
                    ValidTo = dto.ValidTo
                },
                dto.PathLengthConstraint,
                dto.DnsNameText
            );

            if (!string.IsNullOrWhiteSpace(dto.FriendlyNameText))
                rootCertificate.FriendlyName = dto.FriendlyNameText;

            var rsaCertificatePfxBytes = _importExportCertificate.ExportRootPfx(dto.PasswordText, rootCertificate);
            var rootPublicKey = _importExportCertificate.ExportCertificatePublicKey(rootCertificate);
            var rootPublicKeyBytes = rootPublicKey.Export(X509ContentType.Cert);

            return (rootCertificate, rsaCertificatePfxBytes, rootPublicKeyBytes);
        }

        public (X509Certificate2 x509Certificate2, byte[] certificateBytes) CreateSelfSignedCertificate(SelfSignedCertificateDetailsDto dto)
        {
            var basicConstraints = new BasicConstraints
            {
                CertificateAuthority = false,
                HasPathLengthConstraint = false,
                PathLengthConstraint = 0,
                Critical = false
            };

            var subjectAlternativeName = new SubjectAlternativeName
            {
                DnsName = new List<string>
                {
                    dto.DnsNameText,
                }
            };

            var x509KeyUsageFlags = X509KeyUsageFlags.DigitalSignature;

            // only if certification authentication is used
            var enhancedKeyUsages = new OidCollection
            {
                OidLookup.ClientAuthentication,
                OidLookup.ServerAuthentication 
                // OidLookup.CodeSigning,
                // OidLookup.SecureEmail,
                // OidLookup.TimeStamping  
            };

            var certificate = _certificateCreator.NewRsaSelfSignedCertificate(
                new DistinguishedName { CommonName = dto.DnsNameText, Country = dto.CountryText },
                basicConstraints,
                new ValidityPeriod
                {
                    ValidFrom = DateTimeOffset.UtcNow,
                    ValidTo = DateTimeOffset.UtcNow.AddYears(dto.ValidityPeriodInYears)
                },
                subjectAlternativeName,
                enhancedKeyUsages,
                x509KeyUsageFlags,
                new RsaConfiguration
                {
                    KeySize = 2048,
                    HashAlgorithmName = HashAlgorithmName.SHA512
                });

            if (!string.IsNullOrWhiteSpace(dto.FriendlyNameText))
            {
                certificate.FriendlyName = dto.FriendlyNameText;
            }

            var rsaCertPfxBytes = 
                _importExportCertificate.ExportSelfSignedCertificatePfx(dto.PasswordText, certificate);


            return (certificate, rsaCertPfxBytes);
        }

        public (X509Certificate2 x509Certificate2, byte[] certificateBytes) CreateTlsCertificate(
            CertificateDetailsDto dto,
            X509Certificate2 rootCertificate)
        {
            var tlsCertificateLevel1 = _certificatesClientServerAuth.NewServerChainedCertificate(
                new DistinguishedName { 
                    CommonName = dto.CommonNameText, 
                    Country = dto.CountryText                    
                },
                new ValidityPeriod { ValidFrom = dto.ValidFrom, ValidTo = dto.ValidTo },
                dto.DnsNameText,
                rootCertificate
            );

            if (!string.IsNullOrWhiteSpace(dto.FriendlyNameText))
                tlsCertificateLevel1.FriendlyName = dto.FriendlyNameText;

            var tlsCertificateLevel2InPfxBytes = _importExportCertificate.ExportChainedCertificatePfx(
                dto.PasswordText,
                tlsCertificateLevel1,
                rootCertificate
            );

            return (tlsCertificateLevel1, tlsCertificateLevel2InPfxBytes);
        }
    }
}
