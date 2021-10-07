using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page8
{
    public class Program
    {
        public static void Main()
        {
            int[] Ints = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] Strings = {"zero" , "one", "two", "three", "four",
                             "five", "six", "seven", "eight", "nine" };
            List<int> ListInts = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Dictionary<string, int> Str2Int = new Dictionary<string, int>()
         {
                {"zero",0 },{"one",1 },{"two",2 } ,{ "Three",3}, {"four",4 },
                {"five",5 },{"zix",6 },{"seven",7},{"eight",8 } , {"nine",9 }

         };
            // Part 1 is here
            // use a non generic IEnumerable and IEnumerator

            IEnumerable ie1 = Ints;
            IEnumerator c1 = ie1.GetEnumerator();

            // since IEnumerator is non-generic, Current is an Object and i1 (below) is an int
            // this is an example of
            // int = object
            // child = parent, and it is not an implicit conversion: requires cast
            // no intellisense on Current (intellisense only shows object stuff)
            int i1 = (int)c1.Current;

            // Part 2 is here
            // use a non generic IEnumerable and IEnumerator

            IEnumerable<int> ie2 = Ints;
            IEnumerator<int> c = ie2.GetEnumerator();

            // since IEnumerator<int> is generic Current is an int and i2 is an int
            // this is an example of
            // int = int
            // no conversion is required
            // intellisense activated on Current (intellisense shows int stuff)
            int i = c.Current;

            // Part 3 is here
            // use a non generic IEnumerable and IEnumerator

            IEnumerable ie3wrong = Ints;
            IEnumerable ie3 = Strings;
            IEnumerator c3 = ie1.GetEnumerator();
            IEnumerator c3wrong = ie3wrong.GetEnumerator();

            // since IEnumerator is non-generic, Current is an Object and i1 (below) is an int
            // this is an example of
            // int = object
            // child = parent, and it is not an implicit conversion: requires cast
            // no intellisense on Current (intellisense only shows object stuff)
            string i3 = (string)c3.Current;
            string i3wrong = (string)c3wrong.Current;  // this will fail at runtime since current is an int.

            // Part 4 is here
            // use a non generic IEnumerable and IEnumerator

            IEnumerable<string> ie4 = Strings;
            // IEnumerable<string> ie4wrong = Ints;  // this is a compiler error not a runtime error 
            IEnumerator<string> c4 = ie4.GetEnumerator();
            //IEnumerator<string> c4wrong = ie4wrong.GetEnumerator(); // this is a compiler error not a runtime error 

            // since IEnumerator<int> is generic Current is an int and i2 is an int
            // this is an example of
            // int = int
            // no conversion is required
            // intellisense activated on Current (intellisense shows int stuff)
            int i4 = c.Current;




        }
    } 
}
