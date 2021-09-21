using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using tickethelper.Service;
using tickethelper.Service.ActiveDirectory;
using tickethelper.Ui.Core;

namespace tickethelper.Model
{
    public class FriendlyUserAccount
    {
        public readonly SearchResult SearchResult;
        public AccountManager AccountManager;
        private FriendlyUserAccount(SearchResult searchResult)
        {
            SearchResult = searchResult;
            AccountExpires = GetDate("accountExpires");
            BadPwdCount = GetInt("badPwdCount");
            Company = GetString("company");
            Department = GetString("department");
            Description = GetString("description");
            DisplayName = GetString("displayName");
            EmployeeType = GetString("employeeType");
            EmployeeNumber = GetString("employeeNumber");
            ExtensionAttribute5 = GetString("extensionAttribute5");
            ExtensionAttribute8 = GetString("extensionAttribute8");
            ExtensionAttribute10 = GetString("extensionAttribute10");
            ExtensionAttribute11 = GetString("extensionAttribute11");
            GivenName = GetString("givenName");
            Groups = GetGroups();
            Info = GetString("info");
            LockoutTime = GetLong("lockOutTime");
            Mail = GetString("mail");
            ManagerDn = GetString("manager");
            Path = SearchResult.Path;
            PhysicalDeliveryOfficeName = GetString("physicalDeliveryOfficeName");
            PwdLastSet = GetDate("pwdLastSet");
            SamAccountName = FormatAccountName(GetString("sAMAccountName"));
            Surname = GetString("sn");
            TelephoneNumber = GetString("telephoneNumber");
            Mobile = GetString("mobile");
            Title = GetString("title");
            UserAccountControl = GetInt("userAccountControl");
            WhenCreated = (DateTime) SearchResult.Properties["whenCreated"][0];
            AccountManager = new AccountManager(this);
        }

        public DirectoryEntry Entry => EntryManager.GetEntry(Path);
        public AccountManager Manage => AccountManager;
        public string Path { get; set; }
        public string SamAccountName { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string DisplayName { get; set; }
        public string Mail { get; set; }
        public string ManagerDn { get; set; }
        public string PhysicalDeliveryOfficeName { get; set; }
        public string ExtensionAttribute5 { get; set; }
        public string ExtensionAttribute8 { get; set; }
        public string ExtensionAttribute10 { get; set; }
        public string ExtensionAttribute11 { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeNumber { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string TelephoneNumber { get; set; }
        public string Mobile { get; set; }
        public string Company { get; set; }
        public string JoinedName => GivenName is null || Surname is null ? null : $"{GivenName} {Surname}";
        public int? UserAccountControl { get; set; }
        public int? BadPwdCount { get; set; }
        public long? LockoutTime { get; set; }
        public DateTime? AccountExpires { get; set; }
        public DateTime? PwdLastSet { get; set; }
        public DateTime WhenCreated { get; set; }
        public HashSet<string> Groups { get; set; }

        public bool? AutoUnlocked
        {
            get
            {
                if (LockoutTime is 0 || LockoutTime is null) return null;
                try
                {
                    Manage.Unlock();
                    return true;
                }
                catch (UnauthorizedAccessException)
                {
                    NotificationService.Notify("Falha no desbloqueio automático", "Desbloquear conta");
                    return false;
                }
            }
        }

        public void ShowDetails() => new AccountDetailsForm(this).Show();

        public bool IsExpired() => AccountExpires < DateTime.UtcNow && AccountExpires != null;
        public bool IsDisabled() => Convert.ToBoolean(UserAccountControl & 0x0002);

        public bool IsPwdExpired()
        {
            if (PwdLastSet is null) return false;
            return PwdLastSet.Value.AddDays(90) < DateTime.UtcNow;
        }
        private string GetString(string property)
        {
            if (!SearchResult.Properties.Contains(property)) return null;
            var value = SearchResult.Properties[property]?[0].ToString().Trim();
            return string.IsNullOrWhiteSpace(value) ? null : value;
        }

        private int? GetInt(string property) => !SearchResult.Properties.Contains(property)
            ? default
            : SearchResult.Properties[property]?[0] as int?;

        private long? GetLong(string property) => !SearchResult.Properties.Contains(property)
            ? null
            : SearchResult.Properties[property]?[0] as long?;

        private DateTime? GetDate(string property)
        {
            if (!SearchResult.Properties.Contains(property)) return null;
            var fileTime = Convert.ToInt64(SearchResult.Properties[property][0]);
            if (fileTime == 0 || fileTime == long.MaxValue) return null;
            return DateTime.FromFileTimeUtc(fileTime);
        }

        private HashSet<string> GetGroups()
        {
            var groupSet = new HashSet<string>();
            var groups = SearchResult.Properties["memberOf"];
            foreach (var group in groups) groupSet.Add(FormatGroup(group));
            return groupSet;
        }

        private string FormatGroup(object groupObj)
        {
            var group = groupObj.ToString();
            try
            {
                return group.Substring(3, group.IndexOf(",OU") - 3);
            }
            catch (ArgumentOutOfRangeException)
            {
                Log.Add($"Falha ao adicionar {group}, tentando com Index diferente", 2);
                return group.Substring(3, group.IndexOf(",") - 3);
            }
        }

        private string FormatAccountName(string samAccountName)
        {
            if (!samAccountName.Any(char.IsNumber)) return samAccountName.ToUpper();
            var sb = new StringBuilder();
            var index = samAccountName.LastIndexOf(samAccountName.LastOrDefault(char.IsLetter));
            for (var i = 0; i < samAccountName.Length; i++)
            {
                var @char = i is 0 || i == index ? char.ToUpper(samAccountName[i]) : char.ToLower(samAccountName[i]);
                sb.Append($"{@char}");
            }

            return sb.ToString();
        }
        public static FriendlyUserAccount Create(SearchResult result) => new FriendlyUserAccount(result);
    }
}