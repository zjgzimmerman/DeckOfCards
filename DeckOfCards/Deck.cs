using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {

        ArrayList deck = new ArrayList();
        public int cardCount { get; private set; }

        //Create a new unshuffled deck
        public Deck()
        {
            foreach (Card.suits suit in Enum.GetValues(typeof(Card.suits)))
            {
                foreach (Card.ranks value in Enum.GetValues(typeof(Card.ranks)))
                {
                    Card c = new Card(suit, value);
                    this.deck.Add(c);
                    cardCount++;
                }
            }
        }

        //Pop a card off the deck and return it
        public Card drawCard()
        {
            if (cardCount < 1)
            {
                return null;
            }
            else
            {
                Card drawnCard = (Card)this.deck[0];
                this.deck.RemoveAt(0);
                cardCount--;
                return drawnCard;
            }
        }


        public void shuffleDeck()
        {
            ArrayList tempDeck = deck;
            Random rand = new Random();
            int randIndex = 0;
            while (tempDeck.Count > 0)
            {

            }

        }
    }
}
