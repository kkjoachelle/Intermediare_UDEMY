using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public List<Orders> ordersVal;
        public Customer()
        {
            ordersVal = new List<Orders>();
        }
        public Customer(int Id)
            :this()
        {
            this.Id = Id;
        }
        public Customer(int Id , string Name)
            :this(Id)
        {
            this.Name = Name;
        }
        public void Remote()
        {
            ordersVal = new List<Orders>();
        }
    }
}
