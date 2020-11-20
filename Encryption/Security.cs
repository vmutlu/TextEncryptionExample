using Microsoft.AspNetCore.DataProtection;

namespace Encryption
{
    /// <summary>
    /// Encoding text and decrypting the encrypted text according to the given key value. The key can be kept encrypted in the value
    /// </summary>
    public class Security : ISecurity
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;
        private const string Key = "cut-the-night-with-the-light";
        public Security(IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtectionProvider = dataProtectionProvider;
        }
        public string Encrypt(string securityText)
        {
            var protector = _dataProtectionProvider.CreateProtector(Key);
            return protector.Protect(securityText);
        }

        public string Decrypt(string securityText)
        {
            var protector = _dataProtectionProvider.CreateProtector(Key);
            return protector.Unprotect(securityText);
        }
    }
}
