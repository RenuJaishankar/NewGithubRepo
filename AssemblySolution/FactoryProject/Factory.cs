using InterfacesProject;
using System;
using System.Collections.Generic;
using Colors;
using OtherColorsProject;

namespace FactoryProject
{
    public class Factory: IFactory
    {
         int count = 0;
        public IBlack Create(char c)
        {
            switch (char.ToUpper(c))
            {
                case ('B'):return new Black(count++);
                case ('P'): return new Purple(count++);
                case ('O'): return new Orange(count++);
                case ('G'): return new Green(count++);


                default:
                    Console.WriteLine($"did not recognize pattern character '{c}' returning a Black instead");       
                    return new Black(count++);
                    throw new Exception($"did not recognize pattern character '{c}'");

            }
        }
        public Factory()
        {
            IFactory.Prompt = "BP";
        }
        public List<IBlack> Create(string pattern)
        {
            List<IBlack> rv = new List<IBlack>(pattern.Length);
            foreach(char c in pattern)
            {
                rv.Add(Create(c));
            }
            return rv;
        }

        
    }
}
