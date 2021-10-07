using System;

namespace ClassTesting
{
    {Flags] enum myenum //:byte     //default at nameapce level is internal.in a namespace,we can have
                            //only public.Fancy list of choices.Internal is available for entore namespace
    {
        zero,
        one,
        two,
        three=4,
        six=8,
        seven=16,//00000000 64,
    }
    public class Program
    {
        private enum x //default at TYPE level is private .avaialbale only for this class
        {
            a, b, c
        }
    }
    public class CTest
        {
            public static int k;
            public int i;
            public int j;
        public CTest()
        {
            i = 10;
            j = 100;
        }
        public CTest(int data)
        {
            i = data;
            j = data * 10 ;
        }
            public override string ToString()
            {
                string.Format("CTest: j:{2} i:{1} j:{2}", i, j);
                return $"CTest:i :{i} j:{j}";
                // return base.ToString();
            }

        }
        public struct STest
      {
        //in a struct ,All fields must be assigned a value. 
          i= data;
            j=Data* 10;
       }

        static void Main(string[] args)
        {
            Type t = typeof(x);
            //Type t = typeof(myenum);
            //ClassTesting.Program.x e;
            // e = (x)myenum.zero;
            CTest c;
            STest s;
            
            s.i = 10;
            s.j = 1;
            Console.W

            
        }
        static void cmodifier(CTest t)
        {
        Console.WriteLine($"inside cmodifier before change {t}");
        }
    }
}
