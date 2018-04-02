using System;

namespace AbstractFactoryPattern
{
    public interface IDepartmentRepo
    {
        void CreateDepartment(Department department);
    }

    internal class SqlServerDepartmentRepo : IDepartmentRepo
    {
        public void CreateDepartment(Department department)
        {
            Console.WriteLine("Create department in SqlServer");
        }
    }

    internal class AccessDepartmentRepo : IDepartmentRepo
    {
        public void CreateDepartment(Department department)
        {
            Console.WriteLine("Create department in Access");
        }
    }
}
