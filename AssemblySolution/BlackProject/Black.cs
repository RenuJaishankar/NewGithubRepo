using System;

namespace Colors
{
    public class Black : InterfacesProject.IBlack
    {
        public int ID { get; set; } //automatic property -- creates a backing store and implements get and set 'automatically'
                                    //int bs_IDFlagsxaaxcv; the backingstore
                                    //get {return bs_IDFlagsxaaxcv;} set {bs_IDFlagsxaaxcv = value}
         public Black(int id)
        {
            ID = id;
            Console.WriteLine($"{ID,3}>Constructing  a Black");
        }
        ~Black()
        {
            Console.WriteLine($"{ID,3}>Destructing finalizing a Black");
        }
        public void Process()
        {
            Console.WriteLine($"{ID,3}>Process as a Black"); 
        }

        public virtual void vProcess()
        {
            Console.WriteLine($"{ID,3}>VProcess as a Black");
        }
    }
}
