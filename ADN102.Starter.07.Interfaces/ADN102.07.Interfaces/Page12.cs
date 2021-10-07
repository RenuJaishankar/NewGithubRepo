using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page12a
{
    public interface IShape
    {
        double area();
    }

    public class Square : IShape
    {
        double length;

        // overloaded constructor
        public Square(double length)
        {
            this.length = length;
        }

        // interface method:  The Square class is choosing to make the implementation public
        // the area method will be visible in both the square and the IShape
        public double area()
        {
            // area = length * length
            return length * length;
        }
    }

    class Program
    {
        public static void Main()
        {
            double squareLength = 19.50;
            Square sq = new Square(squareLength);
            IShape shape = sq;
            double area1 = sq.area();
            double area2 = shape.area();
            Console.WriteLine(area1);
            Console.WriteLine(area2);
        }
    }
}

namespace Page12b
{
    public interface IShape
    {
        double area();
    }

    public class Square : IShape
    {
        double length;

        // overloaded constructor
        public Square(double length)
        {
            this.length = length;
        }

        // interface method
        public double area()
        {
            // area = length * length
            return length * length;
        }
    }

    public class Circle : IShape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        double IShape.area()
        {
            // area = 3.14 * radius * radius
            return 3.14 * radius * radius;
        }
    }

    class Program
    {
        public static void Main()
        {
            double squareLength = 19.50;
            Square sq = new Square(squareLength);

            double circleRadius = 4;
            Circle cir = new Circle(circleRadius);
            //double circleArea = cir.area();  // this is a compiler error, because cir is a Circle and the area method is not visible 
            // after verifying the error, comment out the previous line

            List<IShape> shapes = new List<IShape>();
            shapes.Add(sq);
            shapes.Add(cir);

            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.area());
            }

        }
    }
}
