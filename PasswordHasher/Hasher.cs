using System;
using System.Security.Cryptography;
using System.Text;

namespace PasswordHasher
{
    internal class Hasher
    {
        private HashAlgorithm _hashType = null;
        private string _valueToHash = String.Empty;

        public string StringHashResult
        {
            get
            {
                return HashPassword(_valueToHash, true);
            }
        }

        public string HexHashResult
        {
            get
            {
                return HashPassword(_valueToHash, false);
            }
        }

        public Hasher(string hashType, string valueToHash)
        {
            _hashType = GetHashAlgorithm(hashType);

            if (!String.IsNullOrEmpty(valueToHash) && valueToHash != _valueToHash)
                _valueToHash = valueToHash;
        }

        private string HashPassword(string passwordToHash, bool returnStringHash)
        {
            byte[] textByteArray = Encoding.ASCII.GetBytes(passwordToHash);
            byte[] hashedBytes = _hashType.ComputeHash(textByteArray);

            if(returnStringHash)
                return Convert.ToBase64String(hashedBytes);
            
            //We're retunring the Hex Hash
            return BitConverter.ToString(hashedBytes).Replace("-", "");
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