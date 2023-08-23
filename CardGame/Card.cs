using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{

    public enum Suit
    {
        Club,
        Spade,
        Diamond,
        Heart
    }

    public enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Card
    {
        private int suit;
        private int rank;

        public Card(int suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public Suit getSuit()
        {
            return (Suit)suit;
        }

        public Rank getRank()
        {
            return (Rank)rank;
        }

        public string shortHand()
        {
            string r;
            char s;
            switch(rank)
            {
                case 11:
                    r = "J";
                    break;
                case 12:
                    r = "Q";
                    break;
                case 13:
                    r = "K";
                    break;
                case 14:
                    r = "A";
                    break;
                default:
                    r = "" + rank;
                    break;
            }

            s = ("" + (Suit)suit)[0];

            return r + s;

        }

        public override string ToString()
        {
            return "" + (Rank)rank + " of " + (Suit)suit;
        }

    }
}
