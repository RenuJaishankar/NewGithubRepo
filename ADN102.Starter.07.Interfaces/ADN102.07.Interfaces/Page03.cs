using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page3
{
    interface IRectangle { double Height { get; } double Width { get; } }

    interface ISquare : IRectangle { double Side { get { return Height; } } }

    interface ICircle { double Radius { get; } }

    interface ITriangle
    {
        double Height { get; }
        double Base { get; }

    }

    class Brick : IRectangle
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public override string ToString()
        {
            return $"Brick: H:{Height} W:{Width} L:{Length}";
        }
    }

    class Sphere : ICircle
    {
        public double Radius { get; set; }
        public override string ToString()
        {
            return $"Sphere: R: {Radius}";
        }
    }
    class Cube : ISquare
    {
        public double Height { get; set; }

        public double Width { get { return Height; } set { Height = value; } }

        public double Length { get { return Height; } set { Height = value; } }

        public override string ToString()
        {
            return $"Cube: H:{Height} W:{Width} L:{Length}";
        }
    }


    class Cylinder : ICircle, IRectangle  // take a look at a can from the top (a circle), then from the side (a rectangle)!
    {
        public double Radius { get; set; }

        public double Height { get; set; }

        public double Width { get { return Radius * 2; } set { Radius = value / 2.0; } }

        public override string ToString()
        {
            return $"Cylinder: H:{Height} R:{Radius} W:{Width}";
        }

    }

    class Pyramid : ITriangle, ISquare   // take a look at a pyramid from the top (a square) and from the side (a triangle)!
    {
        public double Height { get; set; }

        public double Base { get; set; }

        public double Width { get { return Base * 2; } set { Base = value / 2.0; } }

        public override string ToString()
        {
            return $"Pyramid: H:{Height} B:{Base} W:{Width}";
        }
    }

    class Cone : ITriangle, ICircle  // take a look at a cone from the top (a circle) and from the side (a triangle)!
    {
        public double Height { get; set; }

        public double Base { get { return Radius; } set { Radius = value; } }

        public double Radius { get; set; }

        public override string ToString()
        {
            return $"Pyramid: H:{Height} B:{Base} R:{Radius}";
        }
    }


    class Program
    {
        public static void Main()
        {
            List<object> objects = new List<object>()
            {
                new Brick() { Height=10, Length=20, Width=30},
                new Sphere() { Radius=10},
                new Cube() {Height=20},
                new Cylinder() {Height=10,Radius=10},
                new Pyramid() {Height=20, Base=5},
            };
            int i = 1;
            foreach(object o in objects)
            {
                Console.WriteLine($"{i++}:{o}");
            }

            do
            {
                Console.Write("Which object are you interested in?");

                string line = Console.ReadLine();
                bool correct = int.TryParse(line, out i);
                if (!correct)
                {
                    Console.WriteLine("That was not a valid number - try again");
                    continue;
                }
                else
                {
                    if (i <= 0)
                    {
                        Console.WriteLine("That number was not in range (too low).  Goodbye!");
                        return; 
                    }
                    if (i > objects.Count)
                    {
                        Console.WriteLine("That number was not in range (too high)");
                        continue;
                    }
                    object o = objects[i-1];  // because i is a count not an index (it is 1 based)
                    Console.WriteLine($"Testing the {o}");
                    Console.WriteLine($"  is it a rectangle: {o is IRectangle }");
                    Console.WriteLine($"  is it a Square: {o is ISquare }");
                    Console.WriteLine($"  is it a Circle: {o is ICircle }");
                    Console.WriteLine($"  is it a Triangle: {o is ITriangle }");
                }

            } while (i >= 0);
        }
    }


}
