using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    ////read and write example
    //public class Customer
    //{
    //    int id;
    //    string name;
    //    DateTime mEndDate;
    //    public Customer() 
    //    {
    //        Console.WriteLine("Customer constructor call");
    //        id = -1;
    //        name = "not given";
    //        mEndDate = DateTime.Now;
    //    }
    //    public int Id { get { return id; } set { id = value; } }
    //    public string Name { get { return name; } set { name = value; } }
    //    public DateTime MEndDate { get {  return mEndDate; } set {  mEndDate = value; } }
    //}


    //read only example
    //public class Customer
    //{
    //    int id;
    //    string name;
    //    DateTime mEndDate;
    //    public Customer(int id, string name, DateTime mEndDate
    //        )
    //    {
    //        Console.WriteLine("Customer constructor call");
    //        this.id = id;
    //        this.name = name;
    //        this.mEndDate = mEndDate;
    //    }
    //    public int Id { get { return id; } }
    //    public string Name { get { return name; } }
    //    public DateTime MEndDate { get { return mEndDate; } }
    //}

    //write only example
    public class Customer
    {
        int id;
        string name;
        DateTime mEndDate;
        string comment;
        public Customer(int id, string name, DateTime mEndDate
            )
        {
            Console.WriteLine("Customer constructor call");
            this.id = id;
            this.name = name;
            this.mEndDate = mEndDate;
        }
        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public DateTime MEndDate { get { return mEndDate; } }
        public string Comment { set { comment = value; } }
        public void ReadComment(string passCode)
        {
            if (passCode == "admin@123")
            {
                Console.WriteLine("Commen is: " + comment);
            }
        }
    }
}

/*
 * Properties
 * [A.S.] [Mod.] [Data Type] PropertyName {get; set;}
 * get: reading return
 * set: writing value
 * 1. ReadOnly get
 * 2. WriteOnly set
 * 3. Read and Write get, set
 * abstract
 * static
 * autoimplemented
*/