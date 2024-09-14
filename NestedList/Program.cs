using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> myTable = new List<List<int>>();

            myTable.Add(new List<int> { 1,2,3});
            myTable.Add(new List<int> { 4,5});
            myTable.Add(new List<int> { 6,7,8,9});

            foreach(var list in myTable)
            {
                foreach(var item in list)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            
        }
    }
}
