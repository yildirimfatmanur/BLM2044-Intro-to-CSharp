using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compos2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Araba araba1 = new Araba();
            araba1.MotorCalistir();
            Console.ReadLine();
        }

    }
    class Motor
    {
        public int beygirGucu { get; set; }
        public int motorHacmi { get; set; }

        public void calistir()
        {
            Console.WriteLine($"Motor olusturuldu Beygir gücü: {beygirGucu} ve motor hacmi: {motorHacmi}");
        }
    }


    class Araba
    {

        Motor motor;
        public Araba()
        {
            motor = new Motor();
            motor.beygirGucu = 130;
            motor.motorHacmi = 1600;

            Console.WriteLine($"Araba olusturuldu Beygir gücü: {motor.beygirGucu} ve motor hacmi: {motor.motorHacmi}");
        }
        public void MotorCalistir()
        {
            motor.calistir();
        }
    }
}
