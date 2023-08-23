using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Deck
    {
        private List<Card> deck = new List<Card>();
        private static Random rng = new Random();

        public Deck()
        {
            CreateDeck();
        }

        private void CreateDeck()
        {
            deck.Clear();
            for(int i = 0; i < 4; i++)
            {
                for(int j = 2; j < 15; j++)
                {
                    Card c = new Card(i, j);
                    deck.Add(c);
                }
            }
        }

        public void Shuffle()
        {
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var card = deck[k];
                deck[k] = deck[n];
                deck[n] = card;
            }
        }

        public Card draw()
        {
            if (deck.Count == 0)
            {
                Console.WriteLine("Deck is empty!");
                return null;
            }

            Card ret = deck[0];
            deck.RemoveAt(0);
            return ret;
        }


    }
}
