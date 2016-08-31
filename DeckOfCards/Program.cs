using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        //Testing the deck and card classes
        static void Main(string[] args)
        {
            //create some test cards and print them
            Card card1 = new Card(Card.suits.Clubs, Card.ranks.Four);
            Card card2 = new Card(Card.suits.Diamonds, Card.ranks.Queen);

            Console.WriteLine("Card 1 is: {0}", card1.ToString());
            Console.WriteLine("Card 2 is: {0}", card2.ToString());
            Console.WriteLine("Is card 1 greater than card2? {0}", (card1 > card2).ToString());

            Deck deck1 = new Deck();
            deck1.shuffleDeck();
            Card c;
            //iterate through all cards and display the value
            while ((c = deck1.drawCard()) != null)
            {
                Console.WriteLine("Card is: {0}", c.ToString());
                Console.WriteLine("Card count: {0}", deck1.cardCount);
            }
            Console.ReadLine();
        }
    }
}
