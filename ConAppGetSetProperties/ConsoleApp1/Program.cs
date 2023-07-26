using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read and write example
            //Customer customer = new Customer();
            //Console.WriteLine($"Customer ID: {customer.Id} Name: {customer.Name} Membership End Date: {customer.MEndDate}");
            //Console.WriteLine("Enter customer id");
            //customer.Id = int.Parse( Console.ReadLine() );
            //Console.WriteLine("Enter customer name");
            //customer.Name = Console.ReadLine();
            //Console.WriteLine("Enter customer membership end date");
            //customer.MEndDate = DateTime.Parse( Console.ReadLine() );
            //Console.WriteLine("Stored record is as follows");
            //Console.WriteLine($"Customer ID: {customer.Id} Name: {customer.Name} Membership End Date: {customer.MEndDate}");

            ////read only example
            //Customer customer = new Customer(12, "Raju", new DateTime(day: 09, month: 02, year: 2024));
            //Console.WriteLine("Customer details is as follows");
            //Console.WriteLine($"Customer ID: {customer.Id} Name: {customer.Name} Membership End Date: {customer.MEndDate}");
            ////Console.WriteLine("Enter customer id");
            ////customer.Id = int.Parse(Console.ReadLine());
            //compiler throws error as only get property which is read only has been set

            //write only example
            Customer customer = new Customer(12, "Raju", new DateTime(day: 09, month: 02, year: 2024));
            Console.WriteLine("Customer details is as follows");
            Console.WriteLine($"Customer ID: {customer.Id} Name: {customer.Name} Membership End Date: {customer.MEndDate}");
            customer.Comment = "I am delighted with the services provided by the Vendor";
            customer.ReadComment("admin@123");
            //Console.WriteLine("Enter customer id");
            //customer.Id = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
