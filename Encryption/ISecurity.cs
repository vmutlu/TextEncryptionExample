namespace Encryption
{
    public interface ISecurity
    {
        string Encrypt(string securityText);
        string Decrypt(string securityText);
    }
}
