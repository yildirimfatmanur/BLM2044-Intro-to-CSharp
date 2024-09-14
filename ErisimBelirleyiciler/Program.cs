using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Sekil
    {
        protected double kenar1;
    }
    class Kare : Sekil
    {

        public void Kenar(double kenar)
        {
            //kalıtım yolu ile kenar1 alındı
            kenar1 = kenar; // protected olduğu icin sekil clasınadn türetilen Kare classında erişilebiliyor kenar1 degiskenine
        }
        public double AlanGetir()
        {
            return kenar1 * kenar1;
        }
        public void Yazdir()
        {
            Console.WriteLine("Kenar: {0}", kenar1);
            Console.WriteLine("Alan: {0}", AlanGetir());
        }
    }
}
