using WeihanLi.Common.Helpers;

namespace AbstractFactoryPattern
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactoryPattern";
        private static readonly string DbName = ConfigurationHelper.AppSetting("DbName");

        public static IUserRepo CreateUserRepo()
        {
            return (IUserRepo)typeof(DataAccess).Assembly.CreateInstance($"{AssemblyName}.{DbName}UserRepo");
        }

        public static IDepartmentRepo CreateDepartmentRepo()
        {
            return (IDepartmentRepo)typeof(DataAccess).Assembly.CreateInstance($"{AssemblyName}.{DbName}DepartmentRepo");
        }
    }
}
