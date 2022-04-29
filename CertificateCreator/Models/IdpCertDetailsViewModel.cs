using System.Drawing;
using CertificateCreator.Infrastructure.Ui;
using CertificateCreator.Properties;

namespace CertificateCreator.Models
{
    public class IdpCertDetailsViewModel : AppViewModel
    {
        private string _country;
        private string _dnsName;
        private string _friendlyName;
        private string _password;
        private Bitmap _passwordHover;
        private char _passwordMask;
        private int _validityPeriodInYears;

        public IdpCertDetailsViewModel()
        {
            ValidityPeriodInYears = 1;
            PasswordMask = UiConstants.PasswordMask;
            PasswordHover = Resources.eye_icon;
        }

        public IdpCertDetailsViewModel(
            string dnsName,
            string friendlyName,
            string password,
            char passwordMask,
            string country,
            int validityPeriodInYears
        )
        {
            Country = country;
            DnsName = dnsName;
            FriendlyName = friendlyName;
            Password = password;
            PasswordMask = passwordMask;
            ValidityPeriodInYears = validityPeriodInYears;
            PasswordHover = Resources.eye_icon;
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

        public string DnsName
        {
            get => _dnsName ?? string.Empty;
            set
            {
                _dnsName = value;
                OnPropertyChanged(nameof(DnsName));
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

        public string Password
        {
            get => _password ?? string.Empty;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public int ValidityPeriodInYears
        {
            get => _validityPeriodInYears;
            set
            {
                _validityPeriodInYears = value;
                OnPropertyChanged(nameof(ValidityPeriodInYears));
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

        public Bitmap PasswordHover
        {
            get => _passwordHover;
            set
            {
                _passwordHover = value;
                OnPropertyChanged(nameof(PasswordHover));
            }
        }
    }
}
