using System;

namespace ProgramProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Main2(args);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
        static void Main2(string[] args)
        {
            FactoryProject.Factory f = new();
            
            System.Console.Write($"Enter a pattern>[{InterfacesProject.IFactory.Prompt}]:");
            string pattern = Console.ReadLine();
            var MyList = f.Create(pattern);
            foreach(var x in MyList)
            {
                x.Process();
                x.vProcess();
            }
        }
    }
}
