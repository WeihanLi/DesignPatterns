using System;

namespace CompositePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Tree

            var root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var co = new Composite("CompositeA");
            co.Add(new Leaf("Leaf X"));
            co.Add(new Leaf("Leaf Y"));
            var co1 = new Composite("CompositeA");
            co1.Add(new Leaf("Leaf P"));
            co1.Add(new Leaf("Leaf Q"));

            co.Add(co1);
            root.Add(co);
            root.Display(0);

            #endregion Tree

            #region Company

            Company company = new ConcreteCompany("华隆总公司");
            var huaDongCompany = new ConcreteCompany("华隆华东分公司");
            var huaBeiCompany = new ConcreteCompany("华隆华北分公司");
            company.Add(huaDongCompany);
            company.Add(huaBeiCompany);

            huaDongCompany.Add(new HrDepartment("华隆华东分公司Hr部门"));
            huaDongCompany.Add(new FinanceDepartment("华隆华东分公司财务部门"));

            huaBeiCompany.Add(new HrDepartment("华隆华北分公司Hr部门"));
            huaBeiCompany.Add(new FinanceDepartment("华隆华北分公司财务部门"));

            company.Display(0);
            company.LineOfDuty();

            #endregion Company

            Console.ReadLine();
        }
    }
}
