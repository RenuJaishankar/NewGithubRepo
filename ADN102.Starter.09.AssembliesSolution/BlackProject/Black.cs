using System;

namespace Colors
{
    public class Black : InterfacesProject.IBlack
    {
        public int ID { get; set; }

        public Black(int id)
        {
            ID = id;
            Console.WriteLine($"{ID,3}>Constructing a Black");
        }

        ~Black()
        {
            Console.WriteLine($"{ID,3}>Destroying(Finalizing) a Black");
        }

        public void Process()
        {
            Console.WriteLine($"{ID,3}>Process as Black");
        }

        public virtual void vProcess()
        {
            Console.WriteLine($"{ID,3}>vProcess as Black");
        }
    }
}
