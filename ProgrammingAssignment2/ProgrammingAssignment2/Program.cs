using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Imagine you've decided to write a program 
/// to play a game that's nothing like Blackjack.
/// </summary>
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
            Console.WriteLine("Welcome to Nothing Like Blackjack Game!");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card player1Card1 = deck.TakeTopCard();
            Card player2Card1 = deck.TakeTopCard();
            Card player3Card1 = deck.TakeTopCard();
            Card player1Card2 = deck.TakeTopCard();
            Card player2Card2 = deck.TakeTopCard();
            Card player3Card2 = deck.TakeTopCard();

            // flip all the cards over
            player1Card1.FlipOver();
            player1Card2.FlipOver();
            player2Card1.FlipOver();
            player2Card2.FlipOver();
            player3Card1.FlipOver();
            player3Card2.FlipOver();

            // print the cards for player 1
            Console.WriteLine("Player 1: " + player1Card1.Rank + " of " + player1Card1.Suit + ", " + player1Card2.Rank + " of " + player1Card2.Suit);

            // print the cards for player 2
            Console.WriteLine("Player 2: " + player2Card1.Rank + " of " + player2Card1.Suit + ", " + player2Card2.Rank + " of " + player2Card2.Suit);

            // print the cards for player 3
            Console.WriteLine("Player 3: " + player3Card1.Rank + " of " + player3Card1.Suit + ", " + player3Card2.Rank + " of " + player3Card2.Suit);

            Console.ReadLine();
        }
    }
}
