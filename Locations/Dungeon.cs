using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.Locations
{
    class Dungeon
    {
        //Parameters
        public string someObject { get; set; }

        Random random = new Random();

        //Elements from which the rooms will be created
        String[] traits = { "dark", "destroyed", "new"};
        String[] elements = { "chair", "table", "bookshelf" };

        //Constructor
        public Dungeon()
        {
            someObject = GenerateObject();
        }

        //Generates random object for a room
        private string GenerateObject()
        {
            string randomTrait = traits[random.Next(0, traits.Length + 1)];
            string randomElement = elements[random.Next(0, elements.Length + 1)];
            return randomTrait + " " + randomElement;
        }

        //To check if it works
        public void ShowObject()
        {
            Console.WriteLine();
        }
    }
}
