using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarObjectDynamicFarki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = "elma"; // tipi string
            var y = 1;

            object z = "kiraz"; // tipi string degil object
            object t = 3;

            dynamic m = "muz";// tipi dynamic
            dynamic n = 4;

            string a = x;// bu sekilde tanimlayabiliyoruz 
            string b = (string)z;// string b = z bu sekilde tanımlayamıyoruz type casting yapmalıyız
            string c = m; // c nin tipi dynamic olmasına ragmen type casting yapmaya gerek kalmadı. // ama yine de yapsak daha iyi olur.
            Console.WriteLine(a);
            Console.WriteLine(b);  
            Console.WriteLine(c);
            Console.ReadLine();   
        }
    }
}
