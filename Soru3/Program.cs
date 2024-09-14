using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    public delegate int Operation(int x, int y);

    internal class Program
    {
        public static int mult(int x, int y) { return x * y; }
        public static int addi(int x, int y) { return x + y; }
        public static int Arit(int x, int y, Operation op)
        {
            return op(x, y);
        }
        static void Main(string[] args)
        {
            // Operation add = addi;
            // Operation mul = mult;
            Operation add = new Operation(addi);
            Operation mul = new Operation(mult);

            Console.WriteLine("add " + Arit(4, 5, add));
            Console.WriteLine("mul " + Arit(4, 5, mul));

            Console.ReadLine(); 
        }
    }
}
