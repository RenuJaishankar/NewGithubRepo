using InterfacesProject;
using System;
using System.Collections.Generic;

namespace FactoryProject
{
    public class Factory : IFactory
    {
        static Factory()
        {
            IFactory.Prompt = "(B)lack (O)range (G)reen (P)urple";
         }
        static int i = 1;
        public IBlack Create(char c)
        {
            switch(char.ToUpper(c))
            {
                case ('B'): return new Colors.Black(i++);
                case ('O'): return new Colors.Orange(i++);
                case ('G'): return new Colors.Green(i++);
                case ('P'): return new Colors.Purple(i++);
                default: throw new Exception($"did not recognize pattern character '{c}'");
            }
        }
        public List<IBlack> Create(string pattern)
        {
            List<IBlack> rv = new List<IBlack>(pattern.Length);
            foreach (char c in pattern)
            {
                rv.Add(Create(c));
            }
            return rv;
        }
    }
}
