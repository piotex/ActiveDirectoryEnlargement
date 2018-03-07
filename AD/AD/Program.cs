using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AD
{
    class Program
    {
        static void Main(string[] args)
        {
//            ExportToFile("C:\\Users");
//            dod();
//            GetAllData();
//             GetListOfServers();
            //Rename();
//            EnumerateDomainsa();
//            EnumerateOU("OU=Administracja,OU=Computers,OU=Poland,OU=ProLicht,DC=Prolicht,DC=local");

        }

        public static void ExportToFile(string filename)
        {
            string path = @"C:\Users\praktyka\Desktop\AD";
            string NtAccountName = @"Prolicht\praktyka";

            DirectoryInfo di = new DirectoryInfo(path);
            DirectorySecurity acl = di.GetAccessControl(AccessControlSections.All);
            AuthorizationRuleCollection rules = acl.GetAccessRules(true, true, typeof(NTAccount));

            //Go through the rules returned from the DirectorySecurity
            foreach (AuthorizationRule rule in rules)
            {
                //If we find one that matches the identity we are looking for
                if (rule.IdentityReference.Value.Equals(NtAccountName, StringComparison.CurrentCultureIgnoreCase))
                {
                    var filesystemAccessRule = (FileSystemAccessRule)rule;

                    //Cast to a FileSystemAccessRule to check for access rights
                    if ((filesystemAccessRule.FileSystemRights & FileSystemRights.WriteData) > 0 && filesystemAccessRule.AccessControlType != AccessControlType.Deny)
                    {
                        Console.WriteLine(string.Format("{0} has write access to {1}", NtAccountName, path));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("{0} does not have write access to {1}", NtAccountName, path));
                    }
                }
            }

            Console.ReadLine();

        }

        public static void dod()
        {
            var directories = Directory.GetDirectories(@"C:/");

            List<string> lista = new List<string>();


            DirectorySecurity DSA = Directory.GetAccessControl(directories[12]);
            var dirA = Directory.GetDirectories(directories[12]);
            var c = dirA[23];
            var dirAc = Directory.GetDirectories(c);

            foreach (var directory in directories)
            {
                DirectorySecurity DS = Directory.GetAccessControl(directory);
                Boolean WriteAccess = false;
                var dir = Directory.GetDirectories(directory);



                foreach (FileSystemAccessRule Rule in DS.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)))
                {
                    if ((Rule.FileSystemRights & FileSystemRights.Write) != 0)
                    {
                        lista.Add(dir[0]);
                        WriteAccess = true;
                    }
                }
                System.Diagnostics.Debug.WriteLine(WriteAccess.ToString());

            }


            PrincipalContext ctx = new PrincipalContext(ContextType.Domain, "Prolicht");

            // find a user
            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, "praktyka");

            // find the group in question
            GroupPrincipal group = GroupPrincipal.FindByIdentity(ctx, "IT");

            if (user != null)
            {
                // check if user is member of that group
                if (user.IsMemberOf(group))
                {
                    // do something.....
                }
            }
        }

        public static ArrayList EnumerateOU(string OuDn)
        {
            ArrayList alObjects = new ArrayList();
            try
            {
                DirectoryEntry directoryObject = new DirectoryEntry("LDAP://" + OuDn);
                foreach (DirectoryEntry child in directoryObject.Children)
                {
                    string childPath = child.Path.ToString();
                    alObjects.Add(childPath.Remove(0, 7));
                    //remove the LDAP prefix from the path

                    child.Close();
                    child.Dispose();
                }
                directoryObject.Close();
                directoryObject.Dispose();
            }
            catch (DirectoryServicesCOMException e)
            {
                Console.WriteLine("An Error Occurred: " + e.Message.ToString());
            }
            return alObjects;
        }
        public static ArrayList EnumerateDomainsa()
        {
            ArrayList alGCs = new ArrayList();
            Forest currentForest = Forest.GetCurrentForest();
            foreach (GlobalCatalog gc in currentForest.GlobalCatalogs)
            {
                alGCs.Add(gc.Name);
            }
            return alGCs;
        }

        public static ArrayList EnumerateDomains()
        {
            ArrayList alDomains = new ArrayList();
            Forest currentForest = Forest.GetCurrentForest();
            DomainCollection myDomains = currentForest.Domains;

            foreach (Domain objDomain in myDomains)
            {
                alDomains.Add(objDomain.Name);
            }
            return alDomains;
        }
        public static void Rename(string server,string userName, string password, string objectDn, string newName)
        {
            DirectoryEntry child = new DirectoryEntry("LDAP://" + server + "/" + objectDn, userName, password);
            child.Rename("CN=" + newName);
        }

        public static ArrayList GetListOfServers()
        {
            ArrayList alGCs = new ArrayList();
            Forest currentForest = Forest.GetCurrentForest();
            foreach (GlobalCatalog gc in currentForest.GlobalCatalogs)
            {
                alGCs.Add(gc.Name);
            }
            return alGCs;
        }

        private static void GetAllData()
        {
            DirectoryEntry entry = new DirectoryEntry();

            DirectorySearcher searcher = new DirectorySearcher(entry);

            searcher.SearchScope = SearchScope.Subtree;

            searcher.Filter = "(ObjectClass=user)";

            List<string> lista = new List<string>();

            foreach (SearchResult result in searcher.FindAll())
            {
                lista.Add(">" + result.Properties["CN"][0] + "   _____   " + result.Path);
                Console.WriteLine(">" + result.Properties["CN"][0] + "   _____   " + result.Path);
            }

            Console.Read();
        }
    }
}
