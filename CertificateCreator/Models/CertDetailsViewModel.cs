using System;
using System.Drawing;
using CertificateCreator.Infrastructure.Ui;
using CertificateCreator.Properties;

namespace CertificateCreator.Models
{
    public class CertDetailsViewModel : AppViewModel
    {
        private string _commonName;
        private string _country;
        private string _dnsName;
        private string _friendlyName;
        private string _password;
        private Bitmap _passwordHover;
        private char _passwordMask;
        private DateTime? _validFrom;
        private DateTime? _validTo;
        public bool _formEnabled;

        public CertDetailsViewModel()
        {
            PasswordMask = UiConstants.PasswordMask;
            PasswordHover =  Resources.eye_icon;
        }

        public string CommonName
        {
            get => _commonName ?? string.Empty;
            set
            {
                _commonName = value;
                OnPropertyChanged(nameof(CommonName));
            }
        }

        public string DnsName
        {
            get => _dnsName ?? string.Empty;
            set
            {
                _dnsName = value;
                OnPropertyChanged(nameof(DnsName));
            }
        }

        public string Country
        {
            get => _country ?? string.Empty;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        public Bitmap PasswordHover
        {
            get => _passwordHover;
            set
            {
                _passwordHover = value;
                OnPropertyChanged(nameof(PasswordHover));
            }
        }

        public char PasswordMask
        {
            get => _passwordMask;
            set
            {
                _passwordMask = value;
                OnPropertyChanged(nameof(PasswordMask));
            }
        }


        public string Password
        {
            get => _password ?? string.Empty;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string FriendlyName
        {
            get => _friendlyName ?? string.Empty;
            set
            {
                _friendlyName = value;
                OnPropertyChanged(nameof(FriendlyName));
            }
        }


        public DateTime ValidFrom
        {
            get => _validFrom ?? DateTime.Today;
            set
            {
                _validFrom = value;
                OnPropertyChanged(nameof(ValidFrom));
            }
        }

        public DateTime ValidTo
        {
            get => _validTo ?? DateTime.Today.AddYears(5);
            set
            {
                _validTo = value;
                OnPropertyChanged(nameof(ValidTo));
            }
        }

        public bool FormEnabled
        {
            get => _formEnabled;
            set
            {
                _formEnabled = value;
                OnPropertyChanged(nameof(FormEnabled));
            }
        }
    }
}
