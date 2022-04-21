using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Access_Modifiers_Namespace_dll
{
    internal class User
    {
        protected string Email;
        #region Home Work
        string _username;
        string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length >= 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Username must be 6 character at least");
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password is incorrect");
                }
            }
        }

        public User(string username, string pw)
        {
            Username = username;
            Password = pw;
        }

        public bool CheckPassword(string pw)
        {
            if (pw.Length >= 8)
            {
                bool isDigit = false;
                bool isUpper = false;
                bool isLower = false;

                foreach (char letter in pw)
                {
                    if (char.IsDigit(letter))
                    {
                        isDigit = true;
                        continue;
                    }
                    if (char.IsUpper(letter))
                    {
                        isUpper = true;
                        continue;
                    }
                    if (char.IsLower(letter))
                    {
                        isLower = true;
                    }
                }

                bool result = isDigit && isUpper && isLower;

                return result;
            }
            return false;
        }
        #endregion
    }
}
