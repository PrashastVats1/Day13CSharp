using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOOPSExample
{
    /*
     * [A.S.] [Modifier] class <ClassName>:[Base ClassName] [Interfaces]
     * {
     * Members of the class
     * fields
     * properties
     * constructor
     * methods
     * indexer
     * events
     * delegates......
     * }
     */
    public class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Employee Constructor");
            id = -1;
            name = "not given";
        }
        public void Register()
        {
            Console.WriteLine("Enter ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("ID: \t" + id);
            Console.WriteLine("Name: \t" + name);
        }
    }
}
