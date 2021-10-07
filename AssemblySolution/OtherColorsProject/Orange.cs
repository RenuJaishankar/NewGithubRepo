using Colors;
using System;

namespace Colors
{
    public class Orange : Black
    {
        public Orange(int c) : base(c)
        {
            Console.WriteLine($"{ID,3}>Constructing a Orange");
        }
        ~Orange()
        {
            Console.WriteLine($"{ID,3}>Destroying (Finalizing a Orange");
        }
            public void Process()
            {
            Console.WriteLine($"{ID,3}>Process as a Orange");
            }
        public override void vProcess()
        {
            Console.WriteLine($"{ID,3}>VProcess as a Orange");
        }
    }
    }

