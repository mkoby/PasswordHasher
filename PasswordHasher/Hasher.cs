using System;
using System.Security.Cryptography;
using System.Text;

namespace PasswordHasher
{
    internal class Hasher
    {
        private HashAlgorithm _hashType = null;
        private string _stringHash = String.Empty;
        private string _hexHash = String.Empty;

        public string StringHashResult { get { return _stringHash; } }
        public string HexHashResult { get { return _hexHash; } }

        public Hasher(string hashType)
        {
            _hashType = GetHashAlgorithm(hashType);
        }

        public void HashPassword(string passwordToHash)
        {
            byte[] textByteArray = Encoding.ASCII.GetBytes(passwordToHash);
            byte[] hashedBytes = _hashType.ComputeHash(textByteArray);

            _stringHash = Convert.ToBase64String(hashedBytes);
            _hexHash = BitConverter.ToString(hashedBytes).Replace("-", "");
        }

        private HashAlgorithm GetHashAlgorithm(string hashType)
        {
            HashAlgorithm hash = null;
            string hashTypeLower = hashType.ToLowerInvariant();

            switch (hashTypeLower)
            {
                case "md5":
                    hash = new MD5CryptoServiceProvider();
                    break;
                case "ripemd160":
                    hash = new RIPEMD160Managed();
                    break;
                case "sha1":
                    hash = new SHA1CryptoServiceProvider();
                    break;
                case "sha256":
                    hash = new SHA256CryptoServiceProvider();
                    break;
                case "sha384":
                    hash = new SHA384CryptoServiceProvider();
                    break;
                case "sha512":
                    hash = new SHA512CryptoServiceProvider();
                    break;
                default:
                    break;
            }

            return hash;
        }
    }
}
