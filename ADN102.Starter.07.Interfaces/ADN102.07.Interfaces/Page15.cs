using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given the interface IArea below, create a public Rectangle class that implements the interface.
//For the Rectangle class you will need:

//Two double properties, height and width.

//A constructor that accepts values for its two properties.
//The first parameter should be for height, and the second parameter should be for width.

namespace Page15
{
    public interface IArea
    {
        double GetArea();
    }
    public class Rectangle : IArea
    {
        double height;
        double width;
        public Rectangle(double h,double w)
        {
            this.height = h;
            this.width = w;
        }
        public double GetArea()
        {
            return this.height * this.width;
        }


    }
}
