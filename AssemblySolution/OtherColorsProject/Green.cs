using Colors;
using System;

namespace Colors
{
    public class Green : Orange
    {
        public Green(int c) : base(c)

        {
            Console.WriteLine($"{ID,3}>Constructing a Green");
        }
        ~Green()
        {
            Console.WriteLine($"{ID,3}>Destroying (Finalizing a Green");
        }
        public void Process()
        {
            Console.WriteLine($"{ID,3}>Process as a Green");
            }
        public override void vProcess()
        {
            Console.WriteLine($"{ID,3}>VProcess as a Green");
        }
    }
}

