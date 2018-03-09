using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace UsersAccesFromPath
{
    public class Folder
    {
        public List<User> GetUsersList(string path)
        {
            string strFolderPath = @"C:\Users\Piotr\Desktop\syff\Debug";
            List<User> list = new List<User>();

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(strFolderPath);
                DirectorySecurity dirSec = dirInfo.GetAccessControl();

                foreach (FileSystemAccessRule rule in dirSec.GetAccessRules(true, true, typeof(NTAccount)))
                {
                    User user = new User();
                    user.Login = rule.IdentityReference.ToString();
                    user.Allow = rule.AccessControlType == AccessControlType.Allow;
                    user.TypeOfControl = rule.FileSystemRights;
                    list.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "required contact with Piotr Kubon",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }

            Console.WriteLine("\n<> ");

            Console.Read();
            return list;

        }
    }
}