using System;

namespace AbstractFactoryPattern
{
    public interface IUserRepo
    {
        void Insert(User user);

        User GetUser(int userId);
    }

    internal class SqlServerUserRepo : IUserRepo
    {
        public void Insert(User user)
        {
            Console.WriteLine("insert user in SqlServer");
        }

        public User GetUser(int userId)
        {
            Console.WriteLine("Get user from SqlServer by userId");
            return null;
        }
    }

    internal class AccessUserRepo : IUserRepo
    {
        public void Insert(User user)
        {
            Console.WriteLine("insert user in Access");
        }

        public User GetUser(int userId)
        {
            Console.WriteLine("Get user from Access by userId");
            return null;
        }
    }
}
