using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Oef_Gebruiker.Models
{
    internal class UserManager
    {

        public void Register(string username, string password)
        {
            Login newUser = new Login(username, password);
        }
        public bool TryLogin(Login credentials)
        {
            return false;
        }
        private string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
