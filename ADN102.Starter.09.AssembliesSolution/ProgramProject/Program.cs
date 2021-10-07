using System;

namespace ProgramProject
{
    class Program
    {
       
        static void Main(string [] args)
        { 

            // this is a workaround for the new .NET core behavior and Finalizers
            // in .NET core finalizers will not run when the program exits
            // setting a local variable to null does not work, HOWEVER
            // moving the body of Main to another method with the following code does
            // force the finalizers to work.  
            ForceFinalizers(); 
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
        static void ForceFinalizers()
        {
            FactoryProject.Factory f = new FactoryProject.Factory();
            System.Console.Write($"Enter a pattern>{InterfacesProject.IFactory.Prompt}:");
            string pattern = System.Console.ReadLine();
           
            System.Collections.Generic.List<InterfacesProject.IBlack> MyList = f.Create(pattern);

            foreach (InterfacesProject.IBlack b in MyList)
            {
                b.Process();
                b.vProcess();
            }
        }
    }
}
