
    using Colors;
using System;

namespace OtherColorsProject
    {
        public class Purple : Black
        {
            public Purple(int c) : base(c)
            {
                Console.WriteLine($"{ID,3}>Constructing a Purple");
            }
            ~Purple()
            {
                Console.WriteLine($"{ID,3}>Destroying (Finalizing a Purple");
            }
            public void Process()
            {
            Console.WriteLine($"{ID,3}>Process as a urple");
            }
            public override void vProcess()
            {
            Console.WriteLine($"{ID,3}>vProcess as a purple");
        }
        }
    }



