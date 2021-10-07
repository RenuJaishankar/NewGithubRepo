using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page14a
{
    public abstract class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void sayHello()
        {
            Console.WriteLine("Hello, my name is " + this.name);
        }

        public int getAge()
        {
            return this.age;
        }
    }

    public class Teacher : Person
    {
        string subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            setSubject(subject);
        }

        public void setSubject(string subject)
        {
            this.subject = subject;
        }
    }

    class Program
    {
        public static void Main()
        {
            // Tim Boyd is the name, 35 is the age, and Math is the subject.
            Teacher teacher = new Teacher("Tim Boyd", 35, "Math");
            teacher.sayHello();
        }
    }
}

namespace Page14b
{
    public abstract class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void sayHello();

        public int getAge()
        {
            return this.age;
        }
    }

    public class Teacher : Person
    {
        private string subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            setSubject(subject);
        }

        public void setSubject(string subject)
        {
            this.subject = subject;
        }

        public override void sayHello()
        {
            Console.WriteLine("Hello, my name is " + this.name + ", and I teach " + this.subject);
        }
    }

    class Program
    {
       public static void Main()
        {
            // Tim Boyd is the name, 35 is the age, and Math is the subject.
            Teacher teacher = new Teacher("Tim Boyd", 35, "Math");
            teacher.sayHello();
        }
    }
}

