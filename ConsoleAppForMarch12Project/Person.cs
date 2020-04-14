using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForMarch12Project
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public string ToFunnyString()
        {
            if(Age < 2)
            {
                return "Baby";
            }
            else if(Age < 3)
            {
                return "Terrible Two";
            }
            else
        }
    }
}
