using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    class Person
    {
        public string name;// public yazmazsak ya da onun yerine private ya da protected  yazarsak hata veriyor.
        public override string ToString()
        {
            return name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Ahmet";
           
            Object [] vs = new Object [3];
            vs[0] = 1;
            vs[1] = "Ali";
            vs[2] = p;
            //Type t = typeof(Person);
            //Console.WriteLine(t.ToString());    

            foreach(object i in vs)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
                 
        }
    }
}
