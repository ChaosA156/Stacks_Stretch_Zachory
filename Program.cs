using System;
using System.Collections.Generic;

namespace Stacks_Stretch_Zachory
{
    class Program
    {
        static void Main(string[] args)
        {
            //All of the cards in this deck.
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Hearts"),
                new Card("10", "Hearts"),
                new Card("Q", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds"),
            };

            //Counts all of the cards in the deck.
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            //Gives the user a hand of cards. Then proceeds to ask them for one of their cards and takes it.
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            Console.WriteLine("Got any 8's?");
            if(startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }
            //Counts the amount of cards in the deck after the previous event.
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }


        }
    }
}