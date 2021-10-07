using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
     public class Green : Orange
    {

        public Green(int id) : base(id)
        {
            Console.WriteLine($"{ID,3}>Constructing an Green");
        }

        ~Green()
        {
            Console.WriteLine($"{ID,3}>Destroying(Finalizing) an Green");
        }

        public void Process()
        {
            Console.WriteLine($"{ID,3}>Process as Green");
        }

        public override void vProcess()
        {
            Console.WriteLine($"{ID,3}>vProcess as Green");
        }
    }
}
