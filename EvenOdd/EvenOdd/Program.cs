using System;

namespace EvenOdd
{
    class Program
    {

        public static string Main(int number)
        {
            if (number % 2 == 1)
            {
                return "ODD";
            }
            else
            {
                return "EVEN";
            }
        }


    }
}
