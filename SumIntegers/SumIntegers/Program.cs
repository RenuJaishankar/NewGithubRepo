using System;

namespace SumIntegers
{
    class Program
    {
        static void Main()
        {
            string i = Console.ReadLine();

            var instring = i.Split(' ');
            
            int sum = 0;
            foreach(string s in instring)
            {
                int newno;
                if(int.TryParse(s,out newno))
                {
                    sum += newno;
                    Console.WriteLine($"Accepted: {newno},total is now {sum}");
                }
                else
                {
                    Console.WriteLine($"Rejected '{s}' invalid integer");
                }
            }
            Console.WriteLine($"The total final sum of acceptable integers is{sum}");
        }
    }
}
