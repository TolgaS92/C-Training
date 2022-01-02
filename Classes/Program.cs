using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Denver";
            customer.Id = 1;
            customer.FirstName = "Tolga";
            customer.LastName = "Secme";

            Customer customer2 = new Customer
            {

            };
            Console.ReadLine();
        }
    }
}
