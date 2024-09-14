using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2BenimCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ayse");
            Person p2 = new Person("Ahmet");
            Person p3 = new Person("Ali");
            Person p4 = new Person("Ece");

            Person[] tekBoy = new Person[4] {p1,p2,p3,p4};
            Person[,] ikiBoy = new Person[2, 2] { { p1, p2 }, { p3,p4} };

            //tekBoy[0] = p1;
            //tekBoy[1] = p2;
            //tekBoy[2] = p3;
            //tekBoy[3] = p4;

            //ikiBoy[0, 0] = p1;
            //ikiBoy[0, 1] = p2;
            //ikiBoy[1, 0] = p3;
            //ikiBoy[1, 1] = p4;


            foreach(var i in tekBoy)
            {
                Console.Write(i.name + " ");
            }

            Console.WriteLine("\n********");
            
            for(int i =0; i < ikiBoy.GetLength(0); i++)
            {
                for(int j=0; j<ikiBoy.GetLength(1); j++)
                {
                    Console.Write(ikiBoy[i, j].name + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public String name;

        public Person(String name)
        {
            this.name = name;
        }
    }
}
