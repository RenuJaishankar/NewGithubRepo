using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN102._07.Interfaces
{
    class Tester
    {


        static double test(Page15.IArea a)
        {
            return a.GetArea();
        }
        public static void Test_Page15()
        {
            Type t = typeof(Page15.Rectangle);
            var c = t.GetConstructor(new Type[] { typeof(int), typeof(int) });
            if (c == null)
            {
                Console.WriteLine("Failure:I cannot find a constructor that takes two ints in the Rectangle class");
                return;
            }
            Page15.IArea a = c.Invoke(new object[] { 6, 8 }) as Page15.IArea;
            if (a == null)
            {
                Console.WriteLine("Failure:It does not appear that the Rectangle class implements the IArea interface");
                return;
            }
            double result = a.GetArea();
            if (result == 48.0)
            {
                Console.WriteLine("Success. You did it!");
            }
            else
            {
                Console.WriteLine("I can see that you implemented the class and the interface's method. However, the value returned from 'GetArea' is not returning the correct value. Are you multiplying the width by the height?");
            }
        }

        static string test(Page16.IDrawable d)
        {
            return d.GetTopCard();
        }
        public static void Test_Page16()
        {
            Type t = typeof(Page16.Deck);
            var c = t.GetConstructor(new Type[] { typeof(List<string>) });
            if (c == null)
            {
                Console.WriteLine("Failure:I cannot find a constructor that takes 'List<string>' in the Deck class");
                return;

            }
            string[] data = { "QS", "5H", "JD", "2D", "AC" };
            Page16.Deck d = c.Invoke(new object[] { data.ToList() }) as Page16.Deck;
            Page16.IDrawable draw = d as Page16.IDrawable;
            if (draw == null)
            {
                Console.WriteLine("Failure:It does not appear that the Deck class implements the IDrawable interface");
                return;
            }
            string result = test(draw);
            if (result == "QS")
            {
                string result2 = test(draw);
                if (result2 != "5H")
                {
                    Console.WriteLine("I can see that you implemented the deck class to return the top card, but it should then remove it so the next time I call it returns the next card in the deck!");
                }
                else
                {
                    Console.WriteLine("Success... I drew two cards asnd they were as expected.");
                }
            }
            else
            {
                Console.WriteLine("I can see that you implemented the class and the interface's method. However, the value returned from 'GetTopCard' is not returning the correct value. You should be returning the top-most (first) card in the list of cards.");
            }
        }



    }
}

