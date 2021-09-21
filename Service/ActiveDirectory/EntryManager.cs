using System.Configuration;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.InteropServices;
using System.Text;

namespace tickethelper.Service.ActiveDirectory
{
    internal static class EntryManager
    {
        private static Configuration config = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap {ExeConfigFilename = "Config.config"} , ConfigurationUserLevel.None);
        public static string HeiwayDomain = config.AppSettings.Settings["Key0"].Value;
        public static string SchincariolDomain = config.AppSettings.Settings["Key1"].Value;
        public static string UserName;
        private static byte[] _password;
        public static string CurrentDomain => $"LDAP://{Domain.GetCurrentDomain()}";

        // Get the opposite domain in relation to the current domain
        public static string ReverseDomain => CurrentDomain.Equals(HeiwayDomain) ? SchincariolDomain : HeiwayDomain;

        // Decrypts the password back to a string

        public static string Password 
        {
            get => Encoding.UTF8.GetString(_password);
            set => _password = Encoding.UTF8.GetBytes(value);
        }

        // Gets the entry according to informed domain
        public static DirectoryEntry GetEntry(string path) =>
            path.Contains(CurrentDomain)
                ? new DirectoryEntry(path)
                : new DirectoryEntry(path, UserName, Password);

        public static bool ValidateCredentials(string userName, string password)
        {
            UserName = userName.Replace("-forcelogin","");
            Password = password;

            try
            {
                var domain = ReverseDomain;
                _ = GetEntry(domain).NativeObject;
                return true;
            }
            catch (COMException)
            {
                return userName.Contains("-forcelogin");
            }
        }
    }
}