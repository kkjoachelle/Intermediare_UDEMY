using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.ordersVal.Add(new Orders());
            customer.ordersVal.Add(new Orders());

            customer.Remote();
            Console.WriteLine(customer.ordersVal.Count);

            Console.ReadKey();
        }
    }
}
