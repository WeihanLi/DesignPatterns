using System;

namespace PrototypePattern
{
    /// <summary>
    /// ShallowCopy
    /// </summary>
    internal class SimpleResume : ICloneable
    {
        private string _name;
        private string _email;

        private string _timePeriod;
        private string _company;

        public void SetPersonalInfo(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public void SetWorkExperience(string company, string timePeriod)
        {
            _company = company;
            _timePeriod = timePeriod;
        }

        public void Display()
        {
            Console.WriteLine($"{_name} {_email}");
            Console.WriteLine($"工作经历：{_timePeriod} {_company}");
        }

        public object Clone() => MemberwiseClone();
    }
}
