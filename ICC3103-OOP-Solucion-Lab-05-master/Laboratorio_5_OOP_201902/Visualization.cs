using System;
using System.Collections.Generic;
using Laboratorio_5_OOP_201902.Cards;

namespace Laboratorio_5_OOP_201902
{
    public static class Visualization
    {
       
        public static void ShowHand(Hand hand)
        {
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ShowDecks(List<Deck> decks)
        {

        }

        public static void ShowCaptains(List<SpecialCard> captains)
        {

        }

        public static void GetUserInput(int maxInput, bool stopper = false)
        {
            int input = Console.Read();

            if (stopper == false)
            {
                if (input >= 0 && input <= maxInput)
                {
                }
                else
                {
                    ConsoleError("Ingresó un numero no válido");
                }
            }

            else if(stopper == true)
            {
                if (input >= -1 && input <= maxInput)
                {
                }
                else
                {
                    ConsoleError("Ingresó un numero no válido");
                }
            }
        }
        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public static void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void ShowListOptions(List<string> options, string message = null)
        {
            if (message != null)
            {
                Console.WriteLine(message);
            }

            for (int i = 1; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i]}");
            }
            Console.WriteLine($"({0}) {options[0]}");
            Console.WriteLine("");
        }
    }
}
