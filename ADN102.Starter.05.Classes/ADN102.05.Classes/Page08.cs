using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In this exercise you will add some constructors to your Color Class:

//The Color class will expose four constructors

//a Default ctor which will make all values 0, except for the opacity which will be 255. This is the color solid Black.
//a ctor accepting a single integer. all four values will be set to the value supplied.
//a ctor accepting 3 integers. Reading the values as RGB, you will set the amount of
//      Red, Green and Blue to the supplied values, and opacity will be 255.
//a ctor accepting 4 integers. Same as above, but also accepts the opacity as a 4th parameter.

namespace Page8
{
    class Color
    {
        public int Red;
        public int Green;
        public int Blue;
        public int Opacity;


        // add a default color and sets everything to 0 except the opacity which is 255
        // default ctor 
        public Color()
        {
            int Red = 0;
            int Green = 0;
            int Blue = 0;
            int Opacity = 255;
        }

               // ctor accepting 1 integer
        public Color(int Red)
        {

        }
        // add a ctor which takes 3 integers and distributes them to red, green, and blue

        public Color(int Red,int Green,int Blue)
        {

        }

               // add a ctor whihc takes 4 integers and distributes them to red, green, blue, and opacity

        public Color(int Red, int Green, int Blue,int Opacity)
        {

        }


    }
}
