using ASimpleRpg.Characters;
using ASimpleRpg.game;
using System;

namespace ASimpleRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(200, 50);
            DisplayMenu();
        }


        static void DisplayMenu()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Display();

            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Console.Clear();
                StartNewGame();
            }
            else if (menuChoice == "2")
            {
                Console.Clear();
                Console.WriteLine("This would load a game");
                Console.ReadKey();
            }
            else if (menuChoice == "3")
            {
                Console.Clear();
                Console.WriteLine("Good bye");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.Clear();
                DisplayMenu();
            }
        }


        static void StartNewGame()
        {
            NewGame newGame = new NewGame();
            newGame.Start();
        }
    }
}
