using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(3.0, 2.0);
            Complex k = new Complex(7.0, 2.0);
            Console.WriteLine(c);
            Console.WriteLine(c.topla(c,k));
            Console.ReadLine();
        }
    }


    public class Complex
    {
        private double gercek, sanal;
        public Complex(double gercek,double sanal)
        {
            this.gercek = gercek;
            this.sanal = sanal;
        }
        public override string ToString()
        {
            return $"{gercek}+{sanal}i";
        }
        public Complex topla(Complex num1, Complex num2)
        {
            
            double gercek, sanal;
            gercek = num1.gercek+num2.gercek;
            sanal = num1.sanal + num2.sanal;
            Complex sayi = new Complex(gercek,sanal);
            return sayi;

        }
    }
}
