using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog kopek1 = new Dog();
            Animal hayvan1 = new Animal();  
            kopek1.animalSound();
            hayvan1.animalSound();  
            Console.ReadLine();
        }
    }
    class Animal  // Base class (parent) 
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: oink oink");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: hav hav");
        }
    }
}
