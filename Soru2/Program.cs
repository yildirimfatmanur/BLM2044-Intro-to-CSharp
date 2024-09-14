using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 1 };
            Person x = new Person("betul");

            Person y = new Person("betul");

            Person z = new Person("betulş");

            Person t = new Person("dsjl");


            Person[] tekBoy = new Person[] { x, y, z, t };
            Person[,] ikiBoy = new Person[2, 2] { { x, y }, { z, t } };
            //public String toString() { return "betül"; }
            foreach (Person i in tekBoy)
            {
                Console.WriteLine(i.name);
            }
            /*
                        foreach (int i in a)
                        {
                            foreach (int j in a)
                            {
                                Console.WriteLine(ikiBoy[i][j].name);
                            }
                            //namespace.class
                        }
                        Console.ReadLine();

                    for(int i = 0; i < 2; i++)
                        {
                            for(int j = 0; j < 2; j++)
                            {
                                Console.WriteLine(ikiBoy[i][j].name);
                            }

                        }
                    }
            */
            for (int i = 0; i < ikiBoy.GetLength(i); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(ikiBoy[i,j].ToString());
                }
            }
            public String toString() { return "betül"; }

        }

        class Person
        {
            public String name;

            public Person(String n)
            {
                name = n;
            }
        }
    }
}
