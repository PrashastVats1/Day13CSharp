using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritanceEx
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Emplyee constructor!!");
            id = -1;
            name = "notgiven";
            salary = 0.0;
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
