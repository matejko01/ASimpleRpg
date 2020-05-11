using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.Characters
{
    class Weapon
    {
        //properties
        public string name { get; set; }
        public int value { get; set; }
        public int damage { get; set; }

        String[] itemType = { "brass knuckles", "dagger", "sword", "axe", "mace", "greatsword", "war axe", "warhammer" };
        Random random = new Random();

        //constructor
        public Weapon(string _name)
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
            if (name == "brass knuckles")
            {
                value = 10;
                damage = 5;
            }
            else if (name == "dagger")
            {
                value = 25;
                damage = 10;
            }
            else if (name == "sword" || name == "axe" || name == "mace")
            {
                value = 50;
                damage = 25;
            }
            else if (name == "greatsword" || name == "war axe" || name == "warhamer")
            {
                value = 200;
                damage = 50;
            }
            else
            {
                CreateRandomItem();
            }
        }
    }
}
