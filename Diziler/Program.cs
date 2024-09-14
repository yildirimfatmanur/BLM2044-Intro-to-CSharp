using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3 };
            //int[] numbers2 = new int[3];
            //int[] numbers3 = new int[] { 5, 6, 7, };

            //for(int i =0; i<3; i++)
            //{
            //    numbers2[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach(var i in numbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("\n******************");

            //foreach (var i in numbers2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("\n******************");

            //foreach (var i in numbers3)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("\n******************");




            int[,] dizi = new int[2, 2];
            int[,] dizi2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] dizi3 = { { 2, 4 }, { 8, 9 } };

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    dizi[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(dizi[i,j]);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(dizi2[i, j]);
                }
            } 

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(dizi3[i, j]);
                }
            }

            Console.ReadLine();
        }

        
        
    }
}
