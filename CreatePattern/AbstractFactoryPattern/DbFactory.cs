namespace AbstractFactoryPattern
{
    public interface IDbFactory
    {
        IUserRepo CreateUserRepo();

        IDepartmentRepo CreateDepartmentRepo();
    }

    internal class SqlServerFactory : IDbFactory
    {
        public IUserRepo CreateUserRepo()
        {
            return new SqlServerUserRepo();
        }

        public IDepartmentRepo CreateDepartmentRepo()
        {
            return new SqlServerDepartmentRepo();
        }
    }

    internal class AccessFactory : IDbFactory
    {
        public IUserRepo CreateUserRepo()
        {
            return new AccessUserRepo();
        }

        public IDepartmentRepo CreateDepartmentRepo()
        {
            return new AccessDepartmentRepo();
        }
    }
}
