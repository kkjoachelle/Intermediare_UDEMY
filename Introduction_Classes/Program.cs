using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Kouadio Joachim";
            person.Introduce("Rachelle Adjoua");
            Console.WriteLine("--------------------------------");
            var p = person.Parse("koffi");
            Console.WriteLine("------ " +p.Name);
            Console.WriteLine("--------------------------------");
            var p1 = Person.ParseSt("Berenice");
            Console.WriteLine(p1.Name);
            Console.WriteLine("--------------------------------");
            Console.ReadKey();
        }
    }
}
