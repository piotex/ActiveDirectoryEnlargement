using System.Security.AccessControl;

namespace UsersAccesFromPath
{
    public class User
    {
        public string Login;
        public FileSystemRights TypeOfControl;
        public bool Allow;
    }
}