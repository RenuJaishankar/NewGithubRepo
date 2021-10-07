using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page13a
{
    public interface IShape
    {
        double area();
    }

    public interface IAnimal
    {
        string sound();
    }

    // `FurrySquare` inherits from `IShape` and `IAnimal` interfaces
    public interface IFurrySquare : IShape, IAnimal
    {
        string name();
    }

    public class Wobble : IFurrySquare
    {
        private double length;

        public Wobble(double length)
        {
            this.length = length;
        }

        public double area()
        {
            return length * length;
        }

        public string sound()
        {
            return "wobble";
        }

        public string name()
        {
            return "Weeble";
        }
    }

    class Program
    {
        public static void Main()
        {
            Wobble w = new Wobble(12.5);
            IShape s = w;
            IAnimal a = w;
            IFurrySquare fs = w;

            Console.WriteLine("This programs shows that a wobble is an IShape, an IAnimal and an IFurrySquare! (if this program compiles)");
        }
    }
}

namespace Page13b
{
    // `FoodConsumer` interface
    public interface IFoodConsumer
    {
        string eat();
    }

    // `Animal` interface
    public interface IAnimal
    {
        string sound();
    }

    // base class `Mammal` - one method `greet()`
    public class Mammal
    {
        private string name;

        public Mammal(string name)
        {
            this.name = name;
        }

        public string greet()
        {
            return "Hello, I'm " + this.name + ".";
        }
    }

    // `Dog` class inherits from `Mammal` class - inherits the `greet()` method
    // It implements both the `FoodConsumer` and `Animal` interfaces:
    //  - It implements the `FoodConsumer` interface's `eat()` method
    //  - It implements the `Animal` interface's `sound()` method
    public class Dog : Mammal, IFoodConsumer, IAnimal
    {
        public Dog(string name) : base(name) { }

        public string eat()
        {
            return "Yum yum!";
        }

        public string sound()
        {
            return "Woof!";
        }
    }

    public class Program
    {
        public static void Main()
        {
            Dog spot = new Dog("Spot");
            Console.WriteLine(spot.greet());
            Console.WriteLine(spot.eat());
            Console.WriteLine(spot.sound());
        }
    }
}

