using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEngineer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ee = new Engineer("Ayşe", 1); ee.showDetail();
            IEmployee ie = new Engineer("Ali", 2); ie.showDetail();

            Console.ReadLine();
        }
    }


    public interface IEmployee
    {
        void showDetail();
    }
    public class Employee : IEmployee
    {
        public String name;
        public Employee(String n)
        {
            name = n;
        }
        public void showDetail()
        {
            Console.WriteLine(name);
        }
    }

    public class Engineer: Employee
    {
        
        public int dnumber;
        public Engineer(String n, int d):base(n)
        {
            dnumber = d;
        }
        public void showDetail()
        {
            Console.WriteLine(name + " " + dnumber);
        }
    }

}







