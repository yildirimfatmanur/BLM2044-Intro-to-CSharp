using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// parallel programming : TPL(Task Parallel Libraray)

namespace ParalelProgramlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread başladı");
            Task tsk = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Gorev basladı");
                for(int i=0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Task count is " + i);

                }
            });
            Console.WriteLine("Durum: "+tsk.Status.ToString());
            tsk.Wait();
            Console.WriteLine("Durum: " + tsk.Status.ToString());
            tsk.Dispose();
            Console.WriteLine("Main thrad bitti");

            Console.ReadLine();

        }
    }
}
