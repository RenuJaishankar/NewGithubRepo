using System;

namespace ClassesTesting
{
    public class test
    {
        public static int next = 1;
        public int id;
        public test()
        {

        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World!");
            test txxx = new test();
            test tone = new test();
            test t2 = new test();
            Console.WriteLine(tone.id);
            
        }
    }
}
