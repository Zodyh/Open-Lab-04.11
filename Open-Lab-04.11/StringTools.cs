using System;
using System.Linq;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] sort = str.ToArray();
            Array.Sort(sort);
            return new string(sort);
        }
    }
}
