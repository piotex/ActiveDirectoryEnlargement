using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryEntry entry = new DirectoryEntry();

            DirectorySearcher searcher = new DirectorySearcher(entry);

            searcher.SearchScope = SearchScope.Subtree;

            searcher.Filter = "(ObjectClass=user)";

            foreach (SearchResult result in searcher.FindAll())
            {
                Console.WriteLine(result.Properties["CN"][0] + "   _____   " + result.Path);
            }
            Console.Read();
        }
    }
}
