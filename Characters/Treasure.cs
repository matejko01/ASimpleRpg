using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.Characters
{
    class Treasure
    {
        //properties
        public string name { get; set; }
        public int value { get; set; }

        String[] itemType = {"coin", "ring", "bracelet", "necklace", "gem"};
        Random random = new Random();

        //constructor
        public Treasure(string _name)
        {
            name = _name;
            AssignStats();
        }

        //Random item for loot
        public void CreateRandomItem()
        {
            string selectedItem = itemType[random.Next(0, itemType.Length)];
            name = selectedItem;
            AssignStats();
        }

        //To give an item its stats
        public void AssignStats()
        {
            if (name == "coin")
            {
                value = 1;
            }
            else if (name == "ring")
            {
                value = 5;
            }
            else if (name == "bracelet" || name == "necklace")
            {
                value = 10;
            }
            else if (name == "gem")
            {
                value = 25;
            }
            else
            {
                CreateRandomItem();
            }
        }
    }
}
