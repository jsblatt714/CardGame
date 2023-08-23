using System;
using System.Diagnostics;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert(test1());

        }

        public static bool test1()
        {
            Console.WriteLine("Testing draws");

            Deck deck = new Deck();
            deck.Shuffle();

            Console.WriteLine(deck.draw());
            Console.WriteLine(deck.draw());
            Console.WriteLine(deck.draw());
            Console.WriteLine(deck.draw());
            Console.WriteLine(deck.draw());

            Console.WriteLine(deck.draw().shortHand());
            Console.WriteLine(deck.draw().shortHand());
            Console.WriteLine(deck.draw().shortHand());
            Console.WriteLine(deck.draw().shortHand());
            Console.WriteLine(deck.draw().shortHand());

            return true;
        }
    }
}
