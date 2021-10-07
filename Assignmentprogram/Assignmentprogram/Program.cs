using System;

using Assignmentprogram.myNamespace;
using Assignmentprogram.textNamespace;

namespace Assignmentprogram { 

    class Program
    {
        public static void Main(string[] args)

        {
            // AnotherProgram b = new AnotherProgram();
            Assignmentprogram.myNamespace.AnotherProgram.printText();
            
            Assignmentprogram.textNamespace.Myclass.printNew();

        }
    }
}
