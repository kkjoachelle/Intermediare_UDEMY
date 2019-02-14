using System.Collections.Generic;

namespace Constructor
{
    public class Customer
     {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int Id)
            :this()
        {
            this.Id = 12;
        }
        public Customer(int Id, string Name)
            :this(Id)
        {
            this.Name = Name;
        }
    }
}
