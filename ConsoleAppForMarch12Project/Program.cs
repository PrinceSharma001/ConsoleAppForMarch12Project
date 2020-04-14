using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForMarch12Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Prince";
            p.LastName = "Sharma";
            p.Age = -1;

            Console.WriteLine(p.ToFunnyString());
            Console.WriteLine(p.ToString());
        }
    }
}
