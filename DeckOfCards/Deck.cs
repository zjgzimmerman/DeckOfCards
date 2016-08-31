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
        //number of cards currently in the deck
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
        //or return null if deck is empty
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
            ArrayList newDeck = new ArrayList();
            Random rand = new Random();
            int randIndex = 0;

            //while there are still elements in the temporary deck
            //pick out random elements and put them into the new deck
            //then remove from temporary deck
            //once shuffled, then clear original deck and add shuffled elements
            while (tempDeck.Count > 0)
            {
                randIndex = rand.Next(0, tempDeck.Count);
                newDeck.Add(tempDeck[randIndex]);
                tempDeck.RemoveAt(randIndex);
            }
            deck.Clear();
            foreach (Card element in newDeck)
            {
                deck.Add(element);
            }
            cardCount = deck.Count;

        }
    }
}
