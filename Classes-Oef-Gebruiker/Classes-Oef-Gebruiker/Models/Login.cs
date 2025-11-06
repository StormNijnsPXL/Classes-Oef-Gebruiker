using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Oef_Gebruiker.Models
{
    internal class Login
    {
		private string _username;
		public string Username
		{
			get { return _username; }
			set { _username = value; }
		}

		private string _password;
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

        public Login()
        {
            
        }

		public Login(string user, string pass)
		{
			Username = user;
			Password = pass;
		}
    }
}
