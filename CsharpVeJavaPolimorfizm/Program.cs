using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpVeJavaPolimorfizm
{
    //class Animal  // Base class (parent) 
    //{
    //    public virtual void animalSound()// VIRTUAL KISMINI SILINCE HATA VERİYOR
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}

    //class Pig : Animal  // Derived class (child) 
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}

    //class Dog : Animal  // Derived class (child) 
    //{
    //    public override void animalSound()
    //    {
    //        Console.WriteLine("The dog says: bow wow");
    //    }
    //}
    internal class Program
    {
        public class Student
        {
            int number;
            String name;
            public Student(int number, String n)
            {
                this.number = number;
                name = n;
            }
            public String toString()
            {
                return number + " " + name;
            }
        }
        static void Main(string[] args)
        {
            /*Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            string a = "yanda verilen uml diyagramı içersinde uygun c kodunu yazınız java ve c dillerinde polimorfizm" +
                " konusu iarasındaki farkı birer kodla anlatınız methodu açıklayınız java proglama dilinde kullanılan ";
            Console.WriteLine(a.Length);*/


            Console.ReadLine();
        }
    }
}
