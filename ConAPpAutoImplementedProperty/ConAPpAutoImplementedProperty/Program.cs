using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAPpAutoImplementedProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Rajiv");
            Console.WriteLine("Enter Id");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter City");
            customer.City = Console.ReadLine();
            Console.WriteLine("Enter Over Draft Limit");
            customer.ODLimit = double.Parse(Console.ReadLine());
            Console.WriteLine("Customer details are as follows");
            Console.WriteLine($"Id: {customer.Id}  Name { customer.Name} ");
            Console.WriteLine($"City: {customer.City}  ODLimit: {customer.ODLimit}");
            Console.ReadKey();
        }
    }
}
