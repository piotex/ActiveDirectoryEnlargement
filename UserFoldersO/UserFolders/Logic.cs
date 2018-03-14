using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace UserFolders
{
    public class Logic
    {
        List<string> MainList = new List<string>();
        private System.DateTime start;
        private System.DateTime end;

        public List<string> GetUserFolders(string user, string path)
        {
            start = System.DateTime.Now;
            if (Directory.Exists(path))
            {
                try
                {
                    var directories = Directory.GetDirectories(path);
                    foreach (var folder in directories)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(path);
                        DirectorySecurity dirSec = dirInfo.GetAccessControl();
                        foreach (FileSystemAccessRule rule in dirSec.GetAccessRules(true, true, typeof(NTAccount)))
                        {
                            var login = rule.IdentityReference.ToString();
                            if (login == user)
                            {
                                try
                                {
                                    var dsa = Directory.GetDirectories(folder);
                                    MainList.Add(folder);
                                }
                                catch (UnauthorizedAccessException)
                                {
                                }
                            }
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {

                }
                
                /////// iteration on all foldders & check acces
                int counter = 0;
                while (counter < MainList.Count)
                {
                    path = MainList[counter];
                    counter++;
                    try
                    {
                        string[] childPaths = Directory.GetDirectories(path); //get childs to check
                        if (childPaths.Length != 0)
                        {
                            foreach (var childPath in childPaths) // for every child
                            {
                                string child = childPath.Replace("\\\\", "\\"); //correct path
                                DirectoryInfo
                                    dirInfo = new DirectoryInfo(child); //check that user has acces to them
                                DirectorySecurity dirSec = dirInfo.GetAccessControl();
                                foreach (FileSystemAccessRule rule in dirSec.GetAccessRules(true, true,
                                    typeof(NTAccount)))
                                {
                                    var login = rule.IdentityReference.ToString();
                                    if (login == user)
                                    {
                                        try
                                        {
                                            var dsa = Directory
                                                .GetDirectories(child); //check thet you has acces to child
                                            MainList.Add(child);
                                        }
                                        catch (UnauthorizedAccessException)
                                        {
                                        }

                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                    }
                }
                return MainList;
            }
            Exception e = new Exception("main path is incorrect _" + path);
            throw e;
        }
    }
}