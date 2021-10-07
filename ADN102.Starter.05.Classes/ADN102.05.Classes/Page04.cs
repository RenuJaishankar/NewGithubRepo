using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//in this exercise you will create a class to represent the following:

//A color to be used to display an item on the screen. In this exercise a color has 4 attributes:

//Red is the amount of Red, a number from 0 (no red) to 255(lots of red)
//Green is the amount of Green, a number from 0(no green) to 255(lots of green)
//Blue is the amount of Blue, a number from 0( no blue) to 255(lots of blue)
//Opacity is the density of the color: a number from 0 (transparent) to 255(completely opaque)
//Create a class to represent a specific color.  

//  use integer fields to store the values.

namespace Page4
{

    public class Color
    {
        public int Red;
        public int Green;
        public int Blue;
        public int Opacity;


        public Color()
        {
            Red = 1;
            Green = 2;
            Blue = 3;
            Opacity = 4;
        }
        public void display()
        {
            Console.WriteLine($"{Red} {Green} {Blue} {Opacity}");
        }

    }


    class Checkcolor
    {
        public static void main()
        {
            Color newcolor = new Color();
            newcolor.display();

        }
    }

    

}