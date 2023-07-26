using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProExFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //Console.WriteLine("Enter ID");
            //customer.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter name");
            //customer.Name = Console.ReadLine();
            //Console.WriteLine("Customer details");
            //Console.WriteLine("ID: \t" + customer.Id + "\nName: \t" + customer.Name);

            Customer customer = new Customer();
            Customer customer2 = new Customer();
            Console.WriteLine("Enter tax");
            Customer.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine("*** Customer 1 ***");
            Console.WriteLine("Enter Id");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Customer details");
            Console.WriteLine("ID: \t"+customer.Id+"\nName: \t"+customer.Name);

            Console.WriteLine("*** Customer 2 ***");
            Console.WriteLine("Enter Id");
            customer2.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            customer2.Name = Console.ReadLine();
            Console.WriteLine("Customer details");
            Console.WriteLine("ID: \t" + customer2.Id + "\nName: \t" + customer2.Name);

            Console.ReadKey();
        }
    }
}
