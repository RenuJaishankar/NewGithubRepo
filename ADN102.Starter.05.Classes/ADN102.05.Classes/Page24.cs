using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page24
{
    public class Person
    {
        string firstName;
        string lastName;
        string fullName;

        // TODO: Accessors

       

       

      


        public Person()
        {
            this.firstName = "";
            this.lastName = "";
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = this.firstName + this.lastName;
        }
    }
}
