using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArray
{
    public class MaxAmongVal<T> where T : IComparable
    {
        public static T MaxValue(T? valOne, T? valTwo, T? valThree) 
        {
            if (valOne.CompareTo(valTwo) > 0)
            {
                if (valOne.CompareTo(valThree) > 0) return valOne;
                else return valThree;
            }
            else if (valTwo.CompareTo(valThree) > 0) return valTwo;
            else return valThree;

        }
}
}
