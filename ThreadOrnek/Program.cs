using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadOrnek
{

    internal class Program
    {
        public class MyThread
        {
            
            public static void Thread1()
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000); 
                }
                Console.WriteLine("islem bitti");
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
            t1.Start();
            t2.Start();
            Console.ReadLine();

        }
    }
}

