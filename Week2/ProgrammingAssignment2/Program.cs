using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome!");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card player1A = deck.TakeTopCard();
            Card player2A = deck.TakeTopCard();
            Card player3A = deck.TakeTopCard();

            Card player1B = deck.TakeTopCard();
            Card player2B = deck.TakeTopCard();
            Card player3B = deck.TakeTopCard();
            // flip all the cards over

            player1A.FlipOver();
            player2A.FlipOver();
            player3A.FlipOver();
            player1B.FlipOver();
            player2B.FlipOver();
            player3B.FlipOver();

            // print the cards for player 1
            Console.WriteLine("Card1 for player 1 " + player1A.Rank + player1A.Suit);
            Console.WriteLine("Card2 for player 1 " + player1B.Rank + player1B.Suit);

            // print the cards for player 2
            Console.WriteLine("Card1 for player 2 " + player2A.Rank + player2A.Suit);
            Console.WriteLine("Card2 for player 2 " + player2B.Rank + player2B.Suit);

            // print the cards for player 3
            Console.WriteLine("Card1 for player 3 " + player3A.Rank + player3A.Suit);
            Console.WriteLine("Card2 for player 3 " + player3B.Rank + player3B.Suit);

        }
    }
}
