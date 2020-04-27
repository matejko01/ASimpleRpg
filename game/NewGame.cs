using ASimpleRpg.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.game
{
    class NewGame
    {


        public void CreateNewCharacter()
        {
            Console.Clear();
            Player player = new Player(true, "", 0, 0);
            player.Create();

            Console.Clear();
            player.PresentYourself();
        }

        public void CreateNewArmor()
        {
            Armor armor = new Armor("");
            armor.CreateRandomItem();
            Console.WriteLine("name {0}, defense {1}, value {2}", armor.name, armor.defense, armor.value);
        }

        public void CreateNewTrasure()
        {
            Treasure trasure = new Treasure("");
            trasure.CreateRandomItem();
            Console.WriteLine("name {0}, value {1}", trasure.name, trasure.value);
        }

        public void CreateNewWeapon()
        {
            Weapon weapon = new Weapon("");
            weapon.CreateRandomItem();
            Console.WriteLine("name {0}, value {1}, damage {2}", weapon.name, weapon.value, weapon.damage);
        }
    }


}
