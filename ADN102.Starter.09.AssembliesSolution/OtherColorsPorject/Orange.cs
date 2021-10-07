using System;

namespace Colors
{
    public class Orange : Black
    {
        public Orange(int id) :base(id)
        {
            Console.WriteLine($"{ID,3}>Constructing an Orange");
        }

        ~Orange()
        {
            Console.WriteLine($"{ID,3}>Destroying(Finalizing) an Orange");
        }

        public void Process()
        {
            Console.WriteLine($"{ID,3}>Process as Orange");
        }

        public override void vProcess()
        {
                      Console.WriteLine($"{ID,3}>vProcess as Orange");
        }
    }
}
