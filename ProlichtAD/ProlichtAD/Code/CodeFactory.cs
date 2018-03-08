using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace ProlichtAD.Code
{
    public class CodeFactory
    {
        public static string strFolderPath = @"";

        public static List<User> GetUserList(EFiltration filtration)
        {
            return FiltrationDictionary[filtration];
        }

        private static Dictionary<EFiltration,List<User>> FiltrationDictionary = new Dictionary<EFiltration, List<User>>
        {
            {EFiltration.FoldersFromUser, GetFolders()},
            {EFiltration.UsersFromPath, GetUsers()}
        };

        private static List<User> GetFolders()
        {
            return null;
        }
        private static List<User> GetUsers()
        {
            List<User> list = new List<User>();
            DirectoryInfo dirInfo = null;
            DirectorySecurity dirSec = null;
            try
            {
                do
                {
                    Console.Write("Enter existing directory > ");

                } while (!Directory.Exists(strFolderPath));


                dirInfo = new DirectoryInfo(strFolderPath);
                dirSec = dirInfo.GetAccessControl();

                Console.WriteLine(strFolderPath + "\n\r");
                foreach (FileSystemAccessRule rule in dirSec.GetAccessRules(true, true, typeof(NTAccount)))
                {
                    Console.WriteLine("[{0}] - Rule {1} {2} access to {3}",
                        rule.AccessControlType == AccessControlType.Allow ? "grants" : "denies",
                        rule.FileSystemRights,
                        rule.IdentityReference.ToString());
                }
            }

            catch (Exception ex)
            {
                Console.Write("EXCEPTION: ");
                Console.WriteLine(ex.Message);
            }

            return list;
        }
    }
}