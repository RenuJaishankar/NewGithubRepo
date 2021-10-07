using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignmentprogram
{
    namespace myNamespace
    {
        public class AnotherProgram
        {
            //Why this not allowing Main here
            public static void printText()
                {
                    Console.WriteLine("Hello Earth!");


                }
           

        }

    }
        namespace textNamespace
        {
            public class Myclass
            {
                public static void printNew()
                {
                    Console.WriteLine("Hello World!");
                    Console.WriteLine("I am text from the textNamespace.");
                }

            }

        }

  

    
}