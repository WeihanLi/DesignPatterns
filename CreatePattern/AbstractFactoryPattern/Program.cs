using System;
using Autofac;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region AbstractFactory

            IDbFactory factory = new AccessFactory();
            var userRepo = factory.CreateUserRepo();
            userRepo.Insert(null);

            factory = new SqlServerFactory();
            userRepo = factory.CreateUserRepo();
            userRepo.Insert(null);

            #endregion AbstractFactory

            #region AbstractFactory + Reflection

            var departmentRepo = DataAccess.CreateDepartmentRepo();
            departmentRepo.CreateDepartment(null);

            #endregion AbstractFactory + Reflection

            #region AbstractFactory + DependencyInjection

            var builder = new ContainerBuilder();
            builder.RegisterType<SqlServerFactory>().As<IDbFactory>();
            var container = builder.Build();

            var dbFactory = container.Resolve<IDbFactory>();
            dbFactory.CreateDepartmentRepo().CreateDepartment(null);

            #endregion AbstractFactory + DependencyInjection

            Console.ReadLine();
        }
    }
}
