using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Ali");
            Console.WriteLine(p1);
            Console.WriteLine("Ali".Equals(p1));

            Console.ReadLine();
        }
    }


    public class Person
    {
        String name;
        public Person(String n)
        {
            name = n;
        }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object o)
        {
            if(!(o is Person))
            {
                return false;
            }
            return (name == ((Person)o).name);
        }
    }
}
