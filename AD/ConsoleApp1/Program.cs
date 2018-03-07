using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFolderPath = "";

            DirectoryInfo dirInfo = null;

            DirectorySecurity dirSec = null;

            int i = 0;

            try
            {
                // Read the path to the directory
                do
                {
                    Console.Write("Enter existing directory > ");
                    strFolderPath = Console.ReadLine();

                } while (!Directory.Exists(strFolderPath));
                // Get the ACL of the directory
                dirInfo = new DirectoryInfo(strFolderPath);
                dirSec = dirInfo.GetAccessControl();
                // Show the ACEs of the ACL
                i = 0;

                foreach (FileSystemAccessRule rule in dirSec.GetAccessRules(true, true, typeof(NTAccount)))
                {
                    Console.WriteLine("[{0}] - Rule {1} {2} access to {3}", i++,rule.AccessControlType == AccessControlType.Allow ? "grants" : "denies",rule.FileSystemRights,rule.IdentityReference.ToString());

                }
            }

            catch (Exception ex)
            {
                Console.Write("EXCEPTION: ");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n<> ");

            Console.Read();

        }

    }
}
