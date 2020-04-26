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
        public Treasure(string _name, int _value)
        {
            name = _name;
            value = _value;
        }


        public void CreateRandomItem()
        {
            string selectedItem = itemType[random.Next(0, itemType.Length)];
            name = selectedItem;

            if (selectedItem == "coin")
            {
                value = 1;
            }
            else if (selectedItem == "ring")
            {
                value = 5;
            }
            else if (selectedItem == "bracelet" || selectedItem == "necklace")
            {
                value = 10;
            }
            else if (selectedItem == "gem")
            {
                value = 25;
            }
        }
    }
}
