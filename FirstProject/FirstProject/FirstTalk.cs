using System;

namespace FirstProject
{
    class FirstTalk
    {
        public static void Main()
        {
            int customersAge;
            customersAge = 0;
            Console.Write("Hello\\n World!");
            Console.WriteLine(customersAge);
            Console.WriteLine('X');
            customersAge = customersAge + 1;
            Console.WriteLine(customersAge);
            //ask the user for their name
            Console.WriteLine("What is your name?");
            //create a variable to hold their input
            String name;
            //get their input
            // 
            name=Console.ReadLine();
            //put their input into a variable
            // output "Hello" without the linefeed
            Console.Write("Hello");
            //output their name
            Console.Write(name);
            //output the !
            Console.WriteLine("!");
            //output a linefeed
            //console.writeLine($"Hello {name}       ");
            Console.WriteLine("Enter your name again");
           Console.WriteLine($"Hello {Console.ReadLine()}!");
            Environment.Exit(customersAge);
        }
    }
}
