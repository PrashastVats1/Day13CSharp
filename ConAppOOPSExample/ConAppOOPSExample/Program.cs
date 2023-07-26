using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOOPSExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClassName objectName = new ClassName()
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            Console.WriteLine("Enter employee one details");
            employee.Register();
            Console.WriteLine("Enter employee two details");
            employee2.Register();
            Console.WriteLine("Employee one display");
            employee.Display();
            Console.WriteLine("Employee two display");
            employee2.Display();
            Console.ReadKey();
        }
    }
}
