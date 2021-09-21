using System;
using System.Text;
using tickethelper.Properties;
using tickethelper.Service;
using tickethelper.Service.ActiveDirectory;

namespace tickethelper.Model
{
    internal class User
    {
        protected User(FriendlyUserAccount heiwayAccountAccount, FriendlyUserAccount schincariolAccountAccount)
        {
            HeiwayAccount = heiwayAccountAccount;
            SchincariolAccount = schincariolAccountAccount;

            Name = HeiwayAccount.DisplayName ??
                   SchincariolAccount.DisplayName ?? HeiwayAccount.JoinedName ?? SchincariolAccount.JoinedName;
            EmployeeId = HeiwayAccount.ExtensionAttribute5?.ToUpper() ?? SchincariolAccount.SamAccountName;
            GlobalId = HeiwayAccount.EmployeeNumber;
            HeiwayId = HeiwayAccount.SamAccountName;
            Mail = HeiwayAccount.Mail ?? SchincariolAccount.Mail;
            OpCo = HeiwayAccount.PhysicalDeliveryOfficeName;
            Department = SchincariolAccount.Department ?? HeiwayAccount.Department;
            Title = SchincariolAccount.Title ?? HeiwayAccount.Title;
            O365License = HeiwayAccount.ExtensionAttribute11;
            EmployeeType = HeiwayAccount.EmployeeType;
            IsVip = "VIP".Equals(HeiwayAccount.ExtensionAttribute8, StringComparison.OrdinalIgnoreCase);
            IsHeiDm = "HeiDM".Equals(HeiwayAccount.ExtensionAttribute10, StringComparison.OrdinalIgnoreCase);
            TelephoneNumber = HeiwayAccount.TelephoneNumber;
            Mobile = HeiwayAccount.Mobile;
        }

        protected User(FriendlyUserAccount account)
        {
            if (account.Path.Contains(EntryManager.HeiwayDomain)) HeiwayAccount = account;
            else SchincariolAccount = account;

            Name = account.DisplayName ?? $"{account.GivenName} {account.Surname}";
            EmployeeId = HeiwayAccount?.ExtensionAttribute5 ?? SchincariolAccount?.SamAccountName;
            GlobalId = HeiwayAccount?.EmployeeNumber;
            HeiwayId = HeiwayAccount?.SamAccountName;
            Mail = account.Mail;
            OpCo = HeiwayAccount?.PhysicalDeliveryOfficeName;
            Department = account.Department;
            Title = account.Title;
            O365License = account.ExtensionAttribute11;
            EmployeeType = account.EmployeeType;
            IsVip = "VIP".Equals(account.ExtensionAttribute8, StringComparison.OrdinalIgnoreCase);
            IsHeiDm = "HeiDM".Equals(account.ExtensionAttribute10, StringComparison.OrdinalIgnoreCase);
            TelephoneNumber = HeiwayAccount?.TelephoneNumber;
            Mobile = HeiwayAccount?.Mobile;
        }

        public string Name { get; }
        public string GlobalId { get; }
        public string EmployeeId { get; }
        public string HeiwayId { get; }
        public string Mail { get; }
        public string OpCo { get; }
        public string Department { get; }
        public string Title { get; }
        public string O365License { get; set; }
        public string EmployeeType { get; }
        public string TelephoneNumber { get; }
        public string Mobile { get; }
        public bool IsVip { get; }
        public bool IsHeiDm { get; }

        private User _manager;
        private bool _managerIsSet;
        public User Manager
        {
            get
            {
                if (_managerIsSet) return _manager;
                _manager = SearchEngine.GetUser(HeiwayAccount?.ManagerDn ?? SchincariolAccount?.ManagerDn); //as Manager;
                _managerIsSet = true;
                return _manager;
            }
        }

        public FriendlyUserAccount HeiwayAccount { get; }
        public FriendlyUserAccount SchincariolAccount { get; }
        public UserValidator Validate => new UserValidator(this);

        // Returns null if both givenName and surname is null. Allows to use ?? operator.

        public override string ToString() => ToString(false);

        public string ToString(bool copyPhone)
        {
            var marker = Settings.Default.Marker;
            var userData = new StringBuilder()
                .AppendLine($"{marker} Nome: {Name}")
                .AppendLine($"{marker} Matrícula: {EmployeeId ?? "—"}")
                .AppendLine($"{marker} ID: {HeiwayId ?? "—"}")
                .AppendLine($"{marker} E-mail: {Mail ?? "—"}")
                .AppendLine($"{marker} OpCo: {OpCo ?? "—"}")
                .AppendLine($"{marker} Departamento: {Department ?? "—"}")
                .AppendLine($"{marker} Cargo: {Title ?? "—"}");
                userData.Append($"{marker} Telefone: {Mobile ?? "+55"}");
            return userData.ToString();
        }

        public string GetEnglishData()
        {
            var marker = Settings.Default.Marker;
            var userData = new StringBuilder()
                .AppendLine($"{marker} Name: {Name}")
                .AppendLine($"{marker} Employee ID: {EmployeeId ?? "—"}")
                .AppendLine($"{marker} Heiway ID: {HeiwayId ?? "—"}")
                .AppendLine($"{marker} Mail: {Mail ?? "—"}")
                .AppendLine($"{marker} OpCo: {OpCo ?? "—"}")
                .AppendLine(
                    $"{marker} Department: {HeiwayAccount?.Department ?? SchincariolAccount?.Department ?? "—"}")
                .AppendLine($"{marker} Job Title: {HeiwayAccount?.Title ?? SchincariolAccount?.Title ?? "—"}")
                .Append($"{marker} Phone number: {Mobile ?? "+55"}");
            return userData.ToString();
        }
        public int GetScore()
        {
            var score = 0;
            if (Validate.EmployeeIdMatch() && HeiwayAccount?.ExtensionAttribute5 != null) score++;
            if (Validate.NamesMatch()) score++;
            if (Validate.MailsMatch() && (HeiwayAccount?.Mail != null && SchincariolAccount?.Mail != null)) score++;
            if (Mail != null) score++;
            if (Validate.DisplayNameMatch()) score++;
            return score;
        }
        public static User Create(FriendlyUserAccount account) => account is null ? null : new User(account);
        public static User Create(FriendlyUserAccount heiwayAccount, FriendlyUserAccount schincariolAccount) =>
            new User(heiwayAccount, schincariolAccount);
    }
}