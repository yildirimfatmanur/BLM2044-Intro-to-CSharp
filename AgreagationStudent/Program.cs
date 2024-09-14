using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreagationStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ogr = new Student("Ali");
            Department bol1 = new Department("Elektrik",ogr);
            bol1.addStudent();
            University uni1 = new University("Ankara");
            uni1.createDepartment();
            Console.ReadLine();

        }
    }
    class Student
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name; // bunu yazmak gerekiyor
        }
    }
    class Department
    {
        public string depName;
        public Student st;// aggreagation kısmı
       
        public Department(string depName,Student st)
        {
            this.depName = depName; 
            this.st = st;   

        }
      
        public void addStudent()
        {
            Console.WriteLine(st+ " eklendi\n");
        }
        public override string ToString()
        {
            return depName;
        }

    }
    class University
    {
        public string uniName;
        public Student st;
        public Department dep1 = new Department("Makine",st);

        public University(string uniName)
        {
            
            this.uniName = uniName;
            
        }
        public void createDepartment()
        {
            dep1.addStudent();
            Console.WriteLine(dep1 + " bolumu olusturuldu");

        }
    }
}
