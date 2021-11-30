using System;
using static System.Console;
namespace program
{
    class employee
    {
        public int empsalary = 0;
        //public void print()
        //{
        //    Console.WriteLine("\n Salary is " + salary);
        //    Console.WriteLine("\n Name is " + name);
        //}
        //Declare salary
        public int salary
        {
            get;
            set;
        }
        //Declare name
        public string name
        {
            get;
            set;
        }
        //public override string ToString()
        //{

        //    for (int i = 0; i < 1000000; i++) //just user the static array length
        //    {
        //        salary[i].Number = Console.ReadLine();
        //        name[i].Name = Console.ReadLine();
        //    }
        //    return "salary =" + salary + " , "name = " + name;
        //}
        // foreach (var item in newlist.OrderBy(Employee => Employee.salary)) Console.WriteLine(Employee);
    }
    class Program
    {
        public static void Main()
        {
            // Employee e = new Employee();// create object with employee 
            // //e.salary = 50000;
            // //e.name = "Robert";
            // //Console.WriteLine(" Employee Data:{0}", e.salary);
            // //Console.WriteLine(" Employee Data:{0}", e.name);
            // //Console.ReadLine();
            //for (int i = 0; i<2; i++)
            // {
            //    Console.WriteLine("Enter salary", e.salary);
            //    Console.ReadLine();
            //    Console.WriteLine("Enter name", e.name);
            //    Console.ReadLine();
            //    string line = Console.ReadLine();
            //    if (line == "exit")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("salary :" + e.salary + '\t' + "Name :" + e.name);
            //Console.ReadLine();         
            Console.WriteLine("Salary");
            var empsalary = int.Parse(Console.ReadLine());
            var employee1 = new program
            {
            salary = empsalary;
        }
    }
}