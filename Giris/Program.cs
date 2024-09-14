using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class Program
    {
        class Car
        {
            public string model;
            public string color;
            public int year;

            // Create a class constructor with multiple parameters
            public Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }

            static void Main(string[] args)
            {
                Car Ford = new Car("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);

                Person myObj = new Person();
                myObj.Name = "Fatma Nur";
                Console.WriteLine(myObj.Name);


                Console.ReadLine();
            }
        }
    }
}


/*
 * 
 * CONSTRUCTOR OLMADAN
 * class Program
{
  static void Main(string[] args)
  {
    Car Ford = new Car();
    Ford.model = "Mustang";
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}*/

/*
 * CONSTRUCTOR KULLANARAK
 * class Program
{
  static void Main(string[] args)
  {
    Car Ford = new Car("Mustang", "Red", 1969);
    Car Opel = new Car("Astra", "White", 2005);

    Console.WriteLine(Ford.model);
    Console.WriteLine(Opel.model);
  }
}
 */


/* public ==> The code is accessible for all classes
private	 ==> The code is only accessible within the same class
protected ==> The code is accessible within the same class, or in a class that is inherited from that class. 
internal ==> The code is only accessible within its own assembly, but not from another assembly.*/
