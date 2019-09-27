using System;
using System.Collections.Generic;
using Laboratorio_5_OOP_201902.Cards;

namespace Laboratorio_5_OOP_201902
{
    public class Visualization
    {
        public Visualization()
        {

        }
        public void ShowHand(Hand hand)
        {   
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void ShowDecks(List<Deck> decks)
        {

        }

        public void ShowCaptains(List<SpecialCard> captains)
        {

        }

        public void GetUserInput(int maxInput, bool stopper = false)
        {

        }

         public void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

       public void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
