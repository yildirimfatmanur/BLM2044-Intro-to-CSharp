using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myTable = { new int[] { 1, 2 }, new int[] { 0 }, new int[] { 1, 2, 3 } } ;
            int [][] myTabley = new int[3][]{ new int[] { 1, 2 }, new int[] { 0 }, new int[] { 1, 2, 3 } };


            for (int i=0; i<myTable.Length; i++)
            {
                for(int j=0; j<myTable[i].Length; j++)
                {
                    Console.Write(myTable[i][j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
