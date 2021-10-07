using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page4
{
    public interface IWall   // the interface itself is publicly visible outside this file.  The interface itself is allowed to have a visibility modifier
    {
        string Material { get; }              // the members of an interface may not have a visibility modifier: i.e this member is not marked as public
                                              // the class implementing this property will make the decision as to the visibility of Material
        int DamageResistance { get; }      // the members of an interface may not have a visibility modifier: i.e this member is not marked as public
                                           // the class implementing this property will make the decision as to the visibility of Material
    }

    class Window : IWall  // the class is not public, so it is not visible outside this file.  A 'window' can be considered as a type of 'wall'
    {
        string IWall.Material { get { return "glass"; } }    // explicit (visible only in interface IWall )  the Window class decided this is visible only in the interface
        public int DamageResistance { get { return 1; } }     // public   (visible in interface and in child) the Window class decided this is visible in both
                                                              //    the class and the interface

        public int Transparency { get { return 0; } }        // Window only (visible in child only)  this property is not in the interface, so is a child only property
    }

    class Door : IWall
    {
        public string Material { get { return "wood"; } }    // public  (visible in interface and in child) class Door decided this is visible only in both
        public int DamageResistance { get { return 10; } }     // public   (visible in interface and in child) the Door class decided this is visible in both
                                                              //    the class and the interface

        public int Height { get { return 72; } }

    }

    class Program
    {
       public  static void Main()
        {
            Window window = new Window();
            Console.WriteLine("Window");
            Console.WriteLine(window.DamageResistance);
            Console.WriteLine(window.Transparency);
            // window.Material is not accessible through window since is is explicitly implemented in the interface and is not visible in the CHILD

            Door door = new Door();
            Console.WriteLine("Door");
            Console.WriteLine(door.DamageResistance);
            Console.WriteLine(door.Material);
            Console.WriteLine(door.Height);

            Console.WriteLine("Window as wall");
            IWall wall = window;
            Console.WriteLine(wall.Material);
            Console.WriteLine(wall.DamageResistance);
            // wall.Transparency is not accessible through wall since it is a class member added at the CHILD level not the parent level

            Console.WriteLine("Door as wall");
            wall = door;
            Console.WriteLine(wall.Material);
            Console.WriteLine(wall.DamageResistance);
            // wall.Height is not accessible through wall since it is a class member added at the CHILD level not the parent level
           
        }
    }
}
