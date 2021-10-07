using System;

namespace One
{
    class Program
    {
        static void Main()
        {

            //double i;
            ////Convert.ToInt32("123");
            ////Console.WriteLine(long.MaxValue);
            ////Console.WriteLine(long.MinValue);
            //i = double.Parse("         .123e32           ");
            ////return-type     name          (inputs)
            ////int             int.Parse(string s)
            //bool Iscorrect = int.TryParse("123", out i);
            //here is a CSV
            //acountBalance, age, name, birthdate
            decimal accountBalance;
            int age;
            string name;
            DateTime birthdate;
            string data = "13.34,30,Daniel,12/25/1950,5";
            string[] items;
            items = data.Split(',');
            // if (condition) {true}
            if(items.Length !=4)
            {
                throw new Exception($"The number of columns is ionvalid: I was expecting 4 and found {items.Length}");
            }
            string a = "This is a big phrase";
            foreach (var x in a) {
                Console.WriteLine(x);
            }
        }
    }
}
