using System;

namespace PrototypePattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region shallow copy

            var resume = new SimpleResume();
            resume.SetPersonalInfo("小明", "xiaoming@abc.xyz");
            resume.SetWorkExperience("xxx公司", "1990~2000");
            resume.Display();
            var resume1 = (SimpleResume)resume.Clone();
            resume1.SetWorkExperience("xxx企业", "1998~1999");
            resume1.Display();
            var resume2 = (SimpleResume)resume.Clone();
            resume2.SetPersonalInfo("xiaohong", "xiaohong@abc.xyz");
            resume2.Display();

            #endregion shallow copy

            #region deep copy

            var complexResume = new ComplexResume();
            complexResume.SetPersonalInfo("xiaoming", "xiaoming@abc.xyz");
            complexResume.SetWorkExperience("xiaomingTecch", "2001~2005");
            complexResume.Show();

            var complexResume1 = (ComplexResume)complexResume.Clone();
            complexResume1.SetPersonalInfo("xiaohong", "xiaohong@abc.xyz");
            complexResume1.Show();

            #endregion deep copy

            Console.ReadLine();
        }
    }
}
