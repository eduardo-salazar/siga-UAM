using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encriptacion
{
    class EncryptPassphraseAlgorithm
    {
        public static string EncryptSHA1(string passphrase) {
            string psEncrypted="";
            System.Security.Cryptography.SHA1 hash = System.Security.Cryptography.SHA1.Create();
            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
            byte[] combined = encoder.GetBytes(passphrase);
            hash.ComputeHash(combined);
            psEncrypted = Convert.ToBase64String(hash.Hash);
            return psEncrypted;
        }
    }
}
