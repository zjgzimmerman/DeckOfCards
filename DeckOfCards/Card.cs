using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Card
    {
        public enum suits { Clubs, Spades, Diamonds, Hearts };
        public enum ranks { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

        public suits cardSuit { get; private set; }
        public ranks cardRank { get; private set; }


        //Constructor, Requires a suit and rank
        public Card(suits cardSuit, ranks cardRank)
        {
            this.cardSuit = cardSuit;
            this.cardRank = cardRank;
        }

        //card ToString, formats card like "Eight of Diamonds"
        public override string ToString()
        {
            return string.Format("{0} of {1}", cardRank.ToString(), cardSuit.ToString());

        }

        #region Overloaded Operators
        //Overload the > and < operators so cards can be compared
        //Greater than
        public static bool operator >(Card c1, Card c2)
        {
            if (c1.cardRank > c2.cardRank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Less than
        public static bool operator <(Card c1, Card c2)
        {
            if (c1.cardRank < c2.cardRank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
