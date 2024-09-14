using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{



    internal class Program
    {
        static void Main(string[] args)
        {
            House home = new House();
            Console.WriteLine(home);// bu halde calisirsa anlamsız seyler cıkacak

            home = null;// boylece roomlar da yok oldu
            Console.ReadLine(); 
        }

    }



    class House
    {
        private Room r1, r2, r3;
        private List<Room> rooms;
        public House()
        {
            r1 = new Room("Oturma Odasi");
            r2 = new Room("Yemek Odasi");
            r3 = new Room("Yatak Odasi");
            rooms = new List<Room>();
            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
        }

        public override string ToString()
        {
            String str = "";
            foreach(var i in rooms)
            {
                str += $"{i.getName()}\n";
            }
            return str;
        }

    }



    class Room
    {
        private String name;
        public Room(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }


    }

}
