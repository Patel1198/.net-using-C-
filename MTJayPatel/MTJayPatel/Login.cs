using System;
using System.Collections.Generic;
using System.Text;

namespace MTJayPatel
{
    class Login
    {
        // private fields
        private int _id;
        private String _userName;
        private String _password;
        private Dictionary<string, string> loginInfo;

        // properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Username
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Dictionary<string, string> Logininfo{
            get { return loginInfo; }
            set { loginInfo = value; }
        }

        //constructor
        public Login(int id, String userName, String password)
        {
            loginInfo = new Dictionary<string, string>() 
            {     
                { "Admin","password"},
                { "Client","password"},
                { "Administator","password"},
                { "Guest","password"} };
            Id = id;
            Username = userName;
            Password = password;
        }
    }
}
