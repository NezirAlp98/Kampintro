using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1=new Customer();
            customer1.Name = "Nezir Alp";
            customer1.Surname = "Arslan";
            customer1.Id = 123456;

            CustomerManager customerManager=new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
    }

    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added" + " " + customer.Name + " " + customer.Surname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted");
        }
    }
}
