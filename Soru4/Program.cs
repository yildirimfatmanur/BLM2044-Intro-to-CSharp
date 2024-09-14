using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Universty u1 = new Universty();
            Student s1 = new Student("Ali");
            Student s2 = new Student("Elif");

            Console.WriteLine(u1);

            Console.ReadLine();
        }
    }

    class Student
    {
        private String name;
        public Student(String name)
        {
            this.name = name;// ENCAPSULATION
        }

        public String GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return name;
        }
    }




    class Departments
    {
        private String name;
        private String student;
        List<Student> ogrenciler = new List<Student>();

        public Departments(String name,String student)
        {
            this.name = name;
            this.student = student;
        }

        public String getName()
        {
            return name;
        }
        public String getStudent()
        {
            return student;
        }

        public void AddStudent(Student st)
        {
            ogrenciler.Add(st);
        }

        public override string ToString()
        {
            String str = "";
            foreach(var i in ogrenciler)
            {
                str += $"{i.GetName()}\n";
            }
            return str;
        }

    }



    class Universty
    {
        private Departments dept;
        private String name;
        List<Departments> bolumler;

        public Universty()
        {
            Departments b1 = new Departments("Bilgisayar", "Ankara");
            Departments b2 = new Departments("Elektrik", "Ankara");
            bolumler = new List<Departments>();
            bolumler.Add(b1);
            bolumler.Add(b2);
        }
        public void createDepartment(Departments dt)
        {
            bolumler.Add(dt);
        }

        public override string ToString()
        {
            String str = "";
            foreach(var i in bolumler)
            {
                str += $"{i.getName()},{i.getStudent()}\n";
            }
            return str;
        }



    }





}
