using System;
using System.Collections;
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

            //Testing ToString
            Console.WriteLine("Card 1 is: {0}", card1.ToString());
            Console.WriteLine("Card 2 is: {0}", card2.ToString());
            //Testing comparison
            Console.WriteLine("Is card 1 greater than card2? {0}", (card1 > card2).ToString());

            //creating and shuffling a deck of cards
            Deck deck1 = new Deck();
            deck1.shuffleDeck();
            Card c;
            //iterate through all cards and display the value
            while ((c = deck1.drawCard()) != null)
            {
                Console.WriteLine("Card Count: {0} \t\tCard is: {1}",  deck1.cardCount, c.ToString());
            }

          
            Console.ReadLine();
        }

    }
}
