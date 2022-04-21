using MyClasses;
using System;
using System.Text;

namespace P324_Access_Modifiers_Namespace_dll
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home work
            //string username;
            //do
            //{
            //    Console.WriteLine("Please enter username");

            //    username = Console.ReadLine();
            //}
            //while (username.Length < 6);

            //string pw;

            //do
            //{
            //    Console.WriteLine("Please enter password");

            //    pw = Console.ReadLine();
            //} while (!CheckPassword(pw));


            //Console.WriteLine("Please enter your section");

            //string section = Console.ReadLine();

            //Console.WriteLine("Are you super admin?  y/n");

            //string isSuperStr = Console.ReadLine();
            //bool isSuper = false;

            //if (isSuperStr.ToLower().Trim() == "y")
            //{
            //    isSuper = true;
            //}

            //Admin admin = new Admin(username, pw, section, isSuper);

            //admin.getInfo();

            #endregion

            User user = new User("test123","tesT123");
            Console.WriteLine();
            StringBuilder str = new StringBuilder();

            //Doctor doctor = new Doctor();

        }
        public static bool CheckPassword(string pw)
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

    }
    
}
