using CardGame.BusinessLogic;
using System;

namespace CardGame
{
    class Program
    {
        static void Main (string[] args)
        {
            // global exception handling to handle exception across application
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;

            StandardDeckOfCards deckOfCards = new StandardDeckOfCards();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose option:\n1: Play\n2: Shuffle\n3: Restart\n4: Display\n50: Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        deckOfCards.PlayACard();
                        break;

                    case 2:
                        deckOfCards.Shuffle();
                        break;

                    case 3:
                        deckOfCards.Reset();
                        break;

                    case 4:
                        deckOfCards.DisplayCardsInDeck();
                        break;

                    case 50:
                        flag = false;
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
        }

        static void UnhandledExceptionHandler (object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
