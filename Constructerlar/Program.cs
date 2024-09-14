using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructerlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red");
            Console.WriteLine(Ford.model);
            Console.ReadLine();
        }
    }
    class Car
    {
        public string model, color;// public yazmka çok önemli
        public Car(string m, string c)// bu constructeri yazmazsak 13.satirdaki Car Ford = new Car("Mustang", "Red"); bu ifade
        {// hata veriyor
            model = m;
            color = c;
        }
    }
}
