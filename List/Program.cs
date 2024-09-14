using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Person
    {
        public String name { get; set; }   

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);    
            sayilar.Add(30);

            var insanlar = new List<Person>() { new Person() { name = "Can" } };
            insanlar.Add(new Person() { name = "Ali"});
            insanlar.Add(new Person() { name = "Veli" });
            foreach(var x in insanlar)
            {
                Console.WriteLine("Adı: {0}",x.name);
            }



            Console.ReadLine(); 
        }
    }
}
