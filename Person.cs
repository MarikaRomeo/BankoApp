using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankoApp
{
    internal class Person
    {
        public string Name { get; set; }
        public string PersonalNumber { get; set; }
        public Person(string name, string personalNumber)
        {
            Name = name;
            PersonalNumber = personalNumber;
        }
    }
}
