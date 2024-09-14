using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            int[][] myTable = new int[3][];
                        myTable[0] = new int[] { 1, 2, 3 };
                        myTable[1] = new int[] { 4, 5, 6, 7 };
                        myTable[2] = new int[] { 8, 9 };

                        for(int i = 0; i<myTable.Length; i++)
                        {
                            Console.WriteLine("*********");
                            for(int j=0; j<myTable[i].Length; j++)
                            {
                                Console.WriteLine(myTable[i][j]);
                            }
                        }


                        }*/

            int[][] myTable = new int[3][];
            /*int[][] myTable = { new int[] { 1, 2 }, new int[] { 0 }, new int[] { 1, 2, 3 } } ;
            int [][] myTabley = new int[3][]{ new int[] { 1, 2 }, new int[] { 0 }, new int[] { 1, 2, 3 } };*/
            myTable[0] = new int[] { 1, 2 };
            myTable[1] = new int[] { 0 };
            myTable[2] = new int[] { 1, 2, 3 };

            for(int i =0; i<myTable.GetLength(0); i++)
            {
                for(int j =0; j < myTable[i].GetLength(0); j++)
                {
                    Console.Write(myTable[i][j]+" ");
                }
                Console.WriteLine();
            }

            int[,] İkiBoyutluDizi = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // normal dizi boyle tanımlanıyor
            for (int i = 0; i < İkiBoyutluDizi.GetLength(0); i++)
            {
                for (int j = 0; j <İkiBoyutluDizi.GetLength(0); j++)
                {
                    Console.WriteLine(İkiBoyutluDizi[i, j]);
                }
            }
            int[,] baskaBirİkiBoyutluDizi = new int[2, 2];
            baskaBirİkiBoyutluDizi[0, 0] = 1;
            baskaBirİkiBoyutluDizi[0, 1] = 2;
            baskaBirİkiBoyutluDizi[1, 0] = 3;
            baskaBirİkiBoyutluDizi[1, 1] = 4;
            int[,] arr2d = new int[2, 3];
            int[, , ,] arr4d = new int[2, 3,3,6];
            int[][] arr3d = new int[2][];
            //arr2d[0]= new int[3]{ 0, 1, 2};

            int x = 1;
            int y = 4;

            Console.WriteLine($"{x} {y}");




             

                
            
            {

            }

                Console.ReadLine();

        }
    }
}
