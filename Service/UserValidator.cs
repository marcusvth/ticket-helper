using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using tickethelper.Model;

namespace tickethelper.Service
{
    internal class UserValidator
    {
        private readonly FriendlyUserAccount _heiway;
        private readonly FriendlyUserAccount _schincariol;

        public UserValidator(User user)
        {
            _heiway = user.HeiwayAccount;
            _schincariol = user.SchincariolAccount;
        }

        public bool NamesMatch() => ContainsIgnoreNull(_heiway?.GivenName, _schincariol?.GivenName);

        public bool MailsMatch()
        {
            if (string.IsNullOrWhiteSpace(_schincariol?.Mail) || string.IsNullOrWhiteSpace(_heiway?.Mail)) return true;
            return _heiway.Mail.Equals(_schincariol?.Mail, StringComparison.OrdinalIgnoreCase);
        }

        public bool EmployeeIdMatch()
        {
            if (_schincariol is null) return true;
            return string.IsNullOrWhiteSpace(_heiway?.ExtensionAttribute5) ||
                   _schincariol.SamAccountName.Equals(_heiway.ExtensionAttribute5, StringComparison.OrdinalIgnoreCase);
        }

        public bool DisplayNameMatch()
        {
            if (_heiway?.DisplayName is null || _schincariol?.DisplayName is null) return false;
            return string.Compare(_schincariol.DisplayName.Split('-')[0].Trim(), _heiway.DisplayName, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) is 0;
        }

        public bool HasDivergence()
        {
            if (_heiway is null || _schincariol is null) return false;
            return !(EmployeeIdMatch() && MailsMatch() && NamesMatch());
        }

        private bool ContainsIgnoreNull(string a, string b)
        {
            if (a is null || b is null) return false;
            a = a.ToLower();
            b = b.ToLower();
            return a.Contains(b) || b.Contains(a);
        }
    }
}