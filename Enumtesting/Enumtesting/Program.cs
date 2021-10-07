using System;

namespace Enumtesting
{
    [Flags] enum colors //this [Flags] is called an ATTRIBUTE
    {
      red=1,                //00001
      blue=2,               //00010
      green=4,              //00100
      orange=8,             //01000
      black=16,             //10000
      blegh = 13,
      //13 = //01101
      //3 = //00011
      //20 = //10100
      //23 = //10111
      //24   //11000

    }
    struct name
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            colors c;
             c = colors.red;
            //    //c = colors.green;// stores 2 in c
            //                     //int i;
            //                     // c = 0;//it is implicitly converted to red.
            //   // c++;
            //   for(int i=1; i<35;i++,c++)
            //    {
            //        Console.WriteLine($"i:{i} c: {c}");

            //    }
            c = colors.red | colors.green | colors.orange;
            string s = "hello there this is a test        ";
            s.Split(" ",StringSplitOptions.)
            Console.WriteLine(c);
        }
    }
}
