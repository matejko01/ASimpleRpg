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
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("##       ##    ###     #### ##     ##     ##       ## ######## ##     ## ##       ##");
            Console.WriteLine("###     ###   ##  ##    ##  ###    ##     ###     ### ##       ###    ## ##       ##");
            Console.WriteLine("####   ####  ##    ##   ##  #####  ##     ####   #### ##       ####   ## ##       ##");
            Console.WriteLine("##  ###  ## ##      ##  ##  ## ### ##     ##  ###  ## ######## ## ### ## ##       ##");
            Console.WriteLine("##       ## ##########  ##  ##   ####     ##       ## ##       ##   #### ##       ##");
            Console.WriteLine("##       ## ##      ##  ##  ##    ###     ##       ## ##       ##    ###  ##     ## ");
            Console.WriteLine("##       ## ##      ## #### ##     ##     ##       ## ######## ##     ##    #####"   );
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n1) New game\n2) Load game\n3) Exit");

            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Console.Clear();
                NewGame newGame = new NewGame();
                newGame.createNewCharacter();
                Console.ReadKey();
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
    }
}
