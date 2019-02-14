using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetDateNais(new DateTime(2019,01,24));
            Console.WriteLine( person.GetDateNais());
            Console.ReadKey();
        }
    }
}
