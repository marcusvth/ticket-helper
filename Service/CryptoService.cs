using System.Text;
using System.Security.Cryptography;

namespace tickethelper.Service
{
    class CryptoService
    {
        // Encrypts the password in a byte
        public static byte[] Encrypt(string plainPwd)
        {
            byte[] password = Encoding.UTF8.GetBytes(plainPwd);
            byte[] encryptedPwd = ProtectedData.Protect(password, null, DataProtectionScope.CurrentUser);
            return encryptedPwd;
        }

        // Decrypts the password back to a string
        public static string Decrypt(byte[] encryptedPwd) 
        {
            byte[] plainPwd = ProtectedData.Unprotect(encryptedPwd, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(plainPwd, 0, plainPwd.Length);
        }
    }
}
