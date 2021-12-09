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

using var services = new ServiceCollection()
    .AddSingleton<IDbFactory, SqlServerFactory>()
    .BuildServiceProvider();

var dbFactory = services.GetRequiredService<IDbFactory>();
dbFactory.CreateDepartmentRepo().CreateDepartment(null);

#endregion AbstractFactory + DependencyInjection

Console.ReadLine();