using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given the interface IDrawable below, create a public Deck class that implements the interface.
//For the Deck class you will need:

//A property that is a List of strings. This collection will represent the playing cards of the deck.
//Use whatever variable name you'd like.

//A constructor with a single parameter for setting the list of cards.
//This constructor should accept a generic List of string.

//In the IDrawable interface below, the GetTopCard method expects the implementation to get the first item.
//You can use the First() method of the List object to get the first item in the list: e.g.myList.First().

// Make sure your implementation of the interface removes the card from the deck (you are drawing a card from the deck)

namespace Page16
{
    // able to draw a card from the object implementing this interface
    public interface IDrawable
    {
        string GetTopCard();
    }

    class Deck : IDrawable
    {
        List<string> myList = new List<string>();
        public Deck(){
            }
   
        public Deck(List<string> newstring){
        myList = newstring;
           }
        public string GetTopCard()
        {
         string mystring= myList.First();
            Console.WriteLine(mystring);
        return mystring;
        }
        
    }
}
