using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    internal class Product
    {
        private readonly ICollection<string> _parts = new List<string>();

        public void Add(string part) => _parts.Add(part);

        public void Show()
        {
            Console.WriteLine("\n产品 创建----");
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
