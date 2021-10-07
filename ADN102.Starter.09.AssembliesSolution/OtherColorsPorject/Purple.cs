using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
     public class Purple : Black
    {
        public Purple(int id) : base(id)
        {
            Console.WriteLine($"{ID,3}>Constructing an Purple");
        }

        ~Purple()
        {
            Console.WriteLine($"{ID,3}>Destroying(Finalizing) an Purple");
        }

        public void Process()
        {
            Console.WriteLine($"{ID,3}>Process as Purple");
        }

        public override void vProcess()
        {
            Console.WriteLine($"{ID,3}>vProcess as Purple");
        }
    }
}
