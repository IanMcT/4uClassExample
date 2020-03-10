using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4UClass
{
    /// <summary>
    /// Creates a person.
    /// </summary>
    class Person
    {
        private string mFirstName;
        private string mLastName;
        /// <summary>
        /// Gets the first and last name
        /// </summary>
        public string FullName
        {
            get
            {
                return mFirstName + " " + mLastName;
            }
        }
        /// <summary>
        /// Creates a person with a name
        /// </summary>
        /// <param name="f">The first name</param>
        /// <param name="l">The last name</param>
        public Person(string f, string l)
        {
            mFirstName = f;
            mLastName = l;
        }

        public string Jumps()
        {
            return FullName + " Jumped";
        }
        /// <summary>
        /// Jump
        /// </summary>
        /// <param name="h">How high in feet?</param>
        /// <returns></returns>
        public string Jumps(int h)
        {
            return FullName + " jumped " + h.ToString() + " feet";
        }

        public string Jumps(int h, int d)
        {
            return Jumps(h) + " and " + d.ToString() + " feet far";
        }
    }
}
