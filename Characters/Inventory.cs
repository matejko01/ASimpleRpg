using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.Characters
{
    class Inventory
    {
        Armor[] armors = new Armor[100];
        Weapon[] weapons = new Weapon[100];
        Treasure[] treasures = new Treasure[100];

        //Items the player will find
        private void CreateArmor(string armorName)
        {
            Armor armor = new Armor(armorName);
        }

        //check if position in inventory is empty
        private int CheckInventoryPosition()
        {
            int position = 0;
            bool checking = true;

            do
            {
                if (armors[position] == null)
                {
                    checking = false;
                }
                else
                {
                    position++;
                }

            } while (checking);

            return position;
        }

        //Action to pick up items
        public void AddToInventory(string itemName)
        {
            int position = CheckInventoryPosition();
            CreateArmor("cloak");

            armors[position] = armor;
        }

        //Looking into inventory
        public void CheckInventory()
        {
            Console.Clear();
            Console.WriteLine("1)Armors  2)Weapons  3)Treasures");
            string choice = Console.ReadLine();
            int number = 1;

            if (choice == "1")
            {
                Console.WriteLine("Armor:");
                foreach (var item in armors)
                {
                    Console.WriteLine(number + ") " + item);
                }
            }
        }
    }
}

