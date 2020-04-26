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
        public Weapon(string _name, int _value, int _damage)
        {
            name = _name;
            value = _value;
            damage = _damage;
        }


        public void CreateRandomItem()
        {
            string selectedItem = itemType[random.Next(0, itemType.Length)];
            name = selectedItem;

            if (selectedItem == "brass knuckles")
            {
                value = 10;
                damage = 5;
            }
            else if (selectedItem == "dagger")
            {
                value = 25;
                damage = 10;
            }
            else if (selectedItem == "sword" || selectedItem == "axe" || selectedItem == "mace")
            {
                value = 50;
                damage = 25;
            }
            else if (selectedItem == "greatsword" || selectedItem == "war axe" || selectedItem == "warhamer")
            {
                value = 200;
                damage = 50;
            }
        }
    }
}
