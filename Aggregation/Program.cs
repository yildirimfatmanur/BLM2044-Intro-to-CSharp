using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{



    internal class Program
    {
        static void Main(string[] args)
        {
            Classroom sinif = new Classroom();
            Student s1 = new Student(1, "Ali");
            Student s2 = new Student(2, "Ece");
            Student s3 = new Student(3, "Can");

            sinif.AddStudent(s1);
            sinif.AddStudent(s2);   
            sinif.AddStudent(s3);

            //Console.WriteLine(sinif.ToString());
            Console.WriteLine(sinif); // Agrregation.Classroom diye bir sey bastı // sınıf ve hashcode ?
            // bunu bu sekilde kullanmamızı saglayan sey Classroom classı icinde yaptıgımız overrride islemi
            
            Console.WriteLine(s1);
            // bunu bu sekilde kullanmamızı saglayan sey Student icindki override islemi


            sinif = null;// sinifi yok etmis olduk
            Console.WriteLine(sinif);
            Console.WriteLine(s1); // sinif silinmesine ragmen hala s1 var bu ilişki AGGREGATION oluyor 

            Console.ReadLine();
        }
    }



    class Student
    {
        private int id;
        private string name;
        public Student(int id, String name)
        { this.id = id; this.name = name;}

        public String getName() // ENCAPSULATION
        {
            return name;
        }

        public int getId()// ENCAPSULATION
        {
            return id;
        }

        public override string ToString()
        {
            //return base.ToString();
            return "id:"+getId();//"id:" bunu yazmazsan hata veriyor
        }
    }



    class Classroom
    {
        List<Student> students = new List<Student>();
        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        

        public override String ToString() // override yazmazsan olmaz
        {
            String str = "";
            foreach(Student i in students)
            {
                str += $"ID: {i.getId()} Name: {i.getName()}\n";
            }
            return str;
        }
    }



}
