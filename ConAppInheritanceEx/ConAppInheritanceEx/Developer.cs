using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritanceEx
{
    public class Developer : Employee
    {
        string domain;
        string project;
        public Developer()
        {
            Console.WriteLine("Developer Constructor");
            domain = "not given";
            project = "not assigned";
        }
        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }
        public string Project
        {
            get { return project; }
            set { project = value; }
        }
    }
}
