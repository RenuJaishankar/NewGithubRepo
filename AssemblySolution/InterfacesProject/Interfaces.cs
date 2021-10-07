using System;
using System.Collections.Generic;

namespace InterfacesProject
{
     public interface IBlack
    {
        public int ID { get; set; }//property set =mutable(changeable) init = immutable(not changeable except in ctor)
        public void Process(); //method
        public void vProcess();   //method
    }

    public interface IFactory
    {
        public static string Prompt { get; set; } = "B"; //public is required due to 'static'
        IBlack Create(char c); // method -- public is optional because this is not static
        List<IBlack> Create(string pattern); //method -- public is optional
    }

    
}
