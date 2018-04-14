using System.Collections.Generic;

namespace VisitorPattern
{
    internal class PersonStructure
    {
        private readonly IList<Person> _persons = new List<Person>();

        public void Attact(Person person)
        {
            _persons.Add(person);
        }

        public void Detach(Person person)
        {
            _persons.Add(person);
        }

        public void Display(AbstractAction visitor)
        {
            foreach (var person in _persons)
            {
                person.Accept(visitor);
            }
        }
    }
}
