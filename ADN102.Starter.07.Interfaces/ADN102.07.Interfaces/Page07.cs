using System;
using System.Collections;
using System.Collections.Generic;

namespace Page7
{
    class Program
    {
        public static void Main(int returnat)
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
            IEnumerable iei = Ints;      // IEnumerable of ints
            IEnumerator ci = iei.GetEnumerator();                               
            
            Console.WriteLine(ci);
            bool value;
            while (true)
            {
                Console.Write(value = ci.MoveNext());
                if (!value) break;
                Console.WriteLine($" {ci.Current.GetType(),20} {ci.Current}");
            }
            Console.WriteLine();

            if (returnat == 1) return;           
            //  Part 2 is here
            IEnumerable ies = Strings;  // IEnumerable of strings
            IEnumerator cs = ies.GetEnumerator();                               
            Console.WriteLine(cs);

            while (true)
            {
                Console.Write(value = cs.MoveNext());
                if (!value) break;
                Console.WriteLine($" {cs.Current.GetType(),20} {cs.Current}");
            }
            Console.WriteLine();
            if (returnat == 2) return;
            //  Part 3 is here
            IEnumerable ieL = ListInts;  // IEnumerable of ints
            IEnumerator cl = ieL.GetEnumerator();                                   
            Console.WriteLine(cl);

            while (true)
            {
                Console.Write(value = cl.MoveNext());
                if (!value) break;
                Console.WriteLine($" {cl.Current.GetType(),20} {cl.Current}");
            }
            Console.WriteLine();
            if (returnat == 3) return;
            // Part 4 is here
            IEnumerable ieD = Str2Int;
            IEnumerator cD = ieD.GetEnumerator();                                  
            Console.WriteLine(cD);

            while (true)
            {
                Console.Write(value = cD.MoveNext());
                if (!value) break;
                Console.WriteLine($" {cD.Current.GetType(),20} {cD.Current}");
            }
            Console.WriteLine();
 
            if (returnat == 4) return;
            //Part 5 is here
            IDictionary id = Str2Int;
            IDictionary<string, int> ids = Str2Int;


            // only one foreach should be uncommented.  pick which one you want to see
            // one is using DictionaryEntry
            // the other is using var (whihc is actually KeyValuePair<string,int>
            foreach (DictionaryEntry x in id)  
            //foreach (var x in ids)  // float cursor over x to see what type is implied: KeyValuePair<string,int>
            {
                Console.WriteLine($"Type: {x.GetType(),20} Key: {x.Key} Value:{x.Value} ");
            }



        }
    }
}
