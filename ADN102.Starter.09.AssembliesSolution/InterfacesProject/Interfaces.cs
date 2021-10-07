using System;
using System.Collections.Generic;
namespace InterfacesProject
{
    public interface IBlack
    {
        public int ID { get; set; }
        public void Process();
        public void vProcess();
    }
    public interface IFactory
    {
        public static string Prompt { get; set; }
        IBlack Create(char c);
        List<IBlack> Create(string pattern);
    }
}
