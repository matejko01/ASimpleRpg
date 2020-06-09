using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.Characters
{
    class Monster
    {
        //properties
        public string name { get; set; }
        public string size { get; set; }

        public int attack { get; set; }
        public int health { get; set; }

        String[] monsters = { "rat", "goblin", "bandit", "orc", "" };
        String[] sizes = { "midget", "small", "regular", "big", "gargantuan" };
        Random random = new Random();

        //constructor
        public Monster(string _name, string _size, int _attack, int _health)
        {
            name = _name;
            size = _size;
            attack = _attack;
            health = _health;
        }

        //Random monster generator
        public void GenerateMonster()
        {
            GenerateName();
            GenerateSize();
        }

        //Random type
        private void GenerateName()
        {
            int namePosition = random.Next(0, monsters.Length);
            bool nameControlValue = false;
            int nameControl = 0;
            attack = 20;
            health = 30;

            name = monsters[namePosition];

            do
            {
                if (nameControl == namePosition)
                {
                    nameControlValue = true;
                }
                else
                {
                    attack += 10;
                    health += 10;
                    nameControl++;
                }

            } while (nameControlValue == false);
        }

        //Random size
        private void GenerateSize()
        {
            int sizePosition = random.Next(0, sizes.Length + 1);
            bool sizeControlValue = false;
            int sizeControl = 0;
            int sizeBonus = -10;

            size = sizes[sizePosition];

            do
            {
                if (sizeControl == sizePosition)
                {
                    attack += sizeBonus;
                    health += sizeBonus;
                    sizeControlValue = true;
                }
                else
                {
                    sizeBonus += 5;
                    sizeControl++;
                }
            } while (sizeControlValue == false);
        }
    }
}
