using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneDizileri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car[] garaj = new Car[3];

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Lambo");
            Car car3 = new Car("Corvette");

            garaj[0] = car1;
            garaj[1] = car2;
            garaj[2] = car3;

            foreach(var i in garaj)
            {
                Console.WriteLine(i.model); // sadece i yazarsan NesneDizileri.Car basıyor yani namespace.class
            }

            Console.ReadLine(); 
        }
    }

    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
