using System;
using System.Collections.;
namespace Testbed
{
    class Program
    {
        static void Main()
        {

            int one = 10;
            //int two = 99;
            //char c = 'a';
            //Console.WriteLine(one);
            //string s = "brian";
            //Console.WriteLine(s);
            //string s2 = s.ToUpper();
            //Console.WriteLine(s2);
            //one = 23;
            //one = one + 9;
            //int[] a = { 0, 7, 89, 90, 56 };
            //string[] names;
            //int i = 0;
            ////a = new int[10]; // indexes are 0 - 9
            //Console.WriteLine(a.Length);
            //List<int> mylist;
            //mylist = new List<int>();
            //mylist.Add(78);
            //mylist.Add(100);
            //mylist.Add(780);
            //mylist.Add(10);
            //mylist.Add(90);
            //mylist.TrimExcess();
            Dictionary<string, int> mydictionary;
            // --optional-- type...................name;
            mydictionary = new Dictionary<string, int>();

            mydictionary.Add("Zero", 0);
            mydictionary.Add("Hundred", 100);
            one = mydictionary["Zero"];
            mydictionary["Zero"] += 10;
            double d;
            int i;
            d = 90;
          //  i = d;//implicit conversion
            i =(int)d; //explicit conversion


        }
    }
}
