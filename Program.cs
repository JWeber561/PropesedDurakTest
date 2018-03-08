using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DurakDeck;

namespace ProposedDurakTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose a deck size");
                int deckSize = Int32.Parse(Console.ReadLine());
                // create a new deck
                Deck myDeck = new Deck(deckSize);
                Console.WriteLine("what's your name");
                Player player1 = new Player(Console.ReadLine());
                // shuffle the deck
                myDeck.Shuffle();
                Console.WriteLine("There are {0} cards in the deck, {1}", myDeck.GetCount(), player1.playerName);
                while (myDeck.GetCount()>0)
                {
                    Console.WriteLine(myDeck.GetCard());
                }
                Console.WriteLine("There are {0} cards in the deck, {1}", myDeck.GetCount(), player1.playerName);
                Console.Write("\n\nPress any key to continue...");
                Console.ReadKey();
                //refill the deck and shuffle it
                myDeck.Refill();
                myDeck.Shuffle();
                try
                {
                    Console.WriteLine("Select an amount of cards to draw:");
                    int drawcount = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < drawcount; i++)
                    {
                        player1.DrawCard(myDeck.GetCard());
                    }
                    for (int i = 0; i < player1.GetCount(); i++)
                    {
                        Console.WriteLine("Card #{0} is, {1}", i+1, player1.GetCard(i));
                    }
                }
                catch (Exception e)
                {
                    // Display the exception message on the console.
                    Console.WriteLine("\n{0}", e.Message);
                }
            }
            catch (Exception e)
            {
                // Display the exception message on the console.
                Console.WriteLine("\n{0}", e.Message);
            }
            // end the program
            Console.Write("\n\nPress any key to end...");
            Console.ReadKey();
        }
    }
}
