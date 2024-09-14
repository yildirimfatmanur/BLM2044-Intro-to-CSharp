using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(azalt);
            Thread t2 = new Thread(arttir);  
            t1.Start();
            t2.Start(); 
            Console.ReadLine();
        }

     public static void azalt()
        {
            for(int i =10; i > 0; i--)
            {
                Console.WriteLine("Timer1 " + i);
                Thread.Sleep(1000); 
            }
            Console.WriteLine("Timer1 in isi bitti");
        }
        public static void arttir()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Timer2 " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer2 nin isi bitti");
        }
    }
    
}

