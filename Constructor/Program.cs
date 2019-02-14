using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                Id = 12,
                Name= "koffi kouadio joachim"
            };
            Console.WriteLine("----- {0}---- {1}",customer.Id, customer.Name );
            Console.WriteLine("----------------------------");
            var order = new Order();
            //customer.orders = new List<Order>();
            //customer.orders.Add(order);

            Console.ReadKey();
        }
    }
}
