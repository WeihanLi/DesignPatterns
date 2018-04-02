using System;

namespace PrototypePattern
{
    internal class WorkExperience : ICloneable
    {
        public string TimePeriod { get; set; }
        public string Company { get; set; }

        public object Clone() => MemberwiseClone();
    }

    /// <summary>
    /// Deep Copy
    /// </summary>
    internal class ComplexResume : ICloneable
    {
        private readonly WorkExperience _workExperience;
        private string _name;
        private string _email;

        public ComplexResume() => _workExperience = new WorkExperience();

        private ComplexResume(WorkExperience workExperience) => _workExperience = (WorkExperience)workExperience.Clone();

        public void SetPersonalInfo(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public void SetWorkExperience(string comapny, string timePeriod)
        {
            _workExperience.Company = comapny;
            _workExperience.TimePeriod = timePeriod;
        }

        public void Show()
        {
            Console.WriteLine($"{_name} {_email}");
            Console.WriteLine($"Work Experience: {_workExperience.Company} {_workExperience.TimePeriod}");
        }

        public object Clone() => new ComplexResume(_workExperience)
        {
            _name = _name,
            _email = _email
        };
    }
}
