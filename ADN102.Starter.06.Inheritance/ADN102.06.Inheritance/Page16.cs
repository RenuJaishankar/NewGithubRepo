using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Each of these classes should inherit from the Animal class shown below.

//For each new class, override the GiveBirth method to produce the following output:

//For the Mammal class, the method should return: "I give live birth"

//For the Bird class, the method should return "I lay eggs"


namespace Page16
{
    public class Animal
    {
        public virtual string GiveBirth()
        {
            return "I don't know how";
        }
        public static void main()
        {
            Mammal mammal = new Mammal();
            mammal.GiveBirth();
            Bird bird = new Bird();
            bird.GiveBirth();
        }
    }


    class Mammal:Animal 
    {
       public string GiveBirth()
        {
            return "I give live birth";
        }
    }

    class Bird : Animal
    {
        public string GiveBirth()
        {
            return "I lay eggs";
        }
    }


    
}
