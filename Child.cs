using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4UClass
{
    internal class Child : Person
    {
        public string TeddyBearName;
        public Child(string f, string l) : base (f, l)
        {

        }

        public override string ToString()
        {
            return FullName + " " + TeddyBearName 
                + " is a very good child";
        }
    }
}
