using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSoru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Universty u1 = new Universty();
            Departments dep = new Departments();
            dep.name = "Makine";
            dep.sehir = "İstanbul";
            
            Student s1 = new Student();
            Student s2 = new Student();
            Console.WriteLine(s1.Name);

            Console.WriteLine(u1);

            Console.ReadLine();
        }
    }

    class Student
    {
        public string Name;  
    }




    class Departments
    {
        public String name;
        public String sehir;
        List<Student> ogrenciler = new List<Student>();

        public void AddStudent(Student st)
        {
            ogrenciler.Add(st);
        }

        public override string ToString()
        {
            String str = "";
            foreach (var i in ogrenciler)
            {
                str += $"{i.Name}\n";
            }
            return str;
        }

    }



    class Universty
    { 
        public String uniName;
        List<Departments> bolumler;

        public Universty()
        {
            Departments b1 = new Departments();
            b1.name = "Bilgisayar";
            b1.sehir = "Istanbul";
            Departments b2 = new Departments();
            b2.name = "Elelktrik";
            b2.sehir = "Ankara";
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
            foreach (var i in bolumler)
            {
                str += $"{i.name},{i.sehir}\n";
            }
            return str;
        }



    }





    

}
