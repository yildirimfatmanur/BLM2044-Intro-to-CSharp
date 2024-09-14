using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class Person
    {
        private string name; // field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }

}
