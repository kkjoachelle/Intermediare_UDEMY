using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10,20);
            point.Move(12,13);
            Console.WriteLine("Les coordonnées sont ({0} et {1})", point.X, point.Y);
            //Console.WriteLine(string.Format("Les coordonnées sont {0} et {1}"),);
            Console.WriteLine("-----------------------------");
            point.Move(new Point(40,50));
            Console.WriteLine("Les coordonnées sont ({0} et {1})",point.X, point.Y);
            Console.WriteLine("-----------------------------");
            var caculator = new Calculator();
            Console.WriteLine(caculator.Add(1,2,3,4,5,6,7,8,9));
            Console.WriteLine(caculator.Add(10,12,13,11));
            Console.WriteLine("-----------------------------");
            Console.ReadKey();
        }
    }
    
}
