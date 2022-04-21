using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Access_Modifiers_Namespace_dll
{
    class Admin:User
    {
        public string Section;
        public bool isSuperAdmin;
        
        
        public Admin(string username, string pw, string section, bool issuper=false):base(username,pw)
        {
            Section = section;
            isSuperAdmin = issuper;
            
        }

        public void getInfo()
        {
            Console.WriteLine($"Username: {Username}, Password: {Password}, Section: {Section}, {(isSuperAdmin ? "This admin is super admin" : "This admin is not super admin")}");
        }

    }
}
