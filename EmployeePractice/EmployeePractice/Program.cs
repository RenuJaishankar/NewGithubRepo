using System;

namespace EmployeePractice
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first integer: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter the second integer: ");
            string s2 = Console.ReadLine();
            int i1 = int.Parse(s1);
            int i2 = int.Parse(s2);
            Console.WriteLine($"The sum of {s1} + {s2}={i1 + i2}");
        }
    }
}
