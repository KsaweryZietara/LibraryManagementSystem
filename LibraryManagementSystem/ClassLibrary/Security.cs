using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary {
    public static class Security {

        /// <summary>
        /// Function hash the password.
        /// </summary>
        /// <param name="password">Password before hashing.</param>
        /// <returns>Password after hashing.</returns>
        public static string PasswordHashing(this string password) {
            
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            return savedPasswordHash;
        }

        /// <summary>
        /// Function check whether the hashed password is the same as saved password hash.
        /// </summary>
        /// <param name="password">Password which user put in.</param>
        /// <param name="savedPasswordHash">Saved hash.</param>
        /// <returns>True if the hashes are the same or false, if not.</returns>
        public static bool CheckPassword(this string password, string savedPasswordHash) {

            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++) {
                if(hashBytes[i+16] != hash[i]) {
                    return false;
                }
            }

            return true;
        } 

    }
}
