using System;
using System.Collections.Generic;
namespace CountYourLetters
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            Console.WriteLine("Type a phrase as a single line sentence");
            String i = Console.ReadLine();
            foreach(char c in i)
            {
                char local;
                local = c;
                local = char.ToUpper(c);
                int current;
                if(counts.TryGetValue(local,out current))
                {
                    counts[local] = current + 1;
                    Console.WriteLine ($"Already Counted '{local}', { current} times, adding one more");

                }
                else
                {
                    counts.Add(local, 1);
                    Console.WriteLine($"not seen '{c}'before setting it to 1");
                }

            }
            Console.WriteLine("Done Processing");
            foreach(var data in counts)
            {
                Console.WriteLine($"'{ data.Key }` was found {data.Value} time(s)");
            }
        }
    }
}
