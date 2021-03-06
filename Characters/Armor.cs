﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.Characters
{
    class Armor
    {
        //properties
        public string name { get; set; }
        public int value { get; set; }
        public int defense { get; set; }

        String[] itemType = { "cloak", "gambison", "haubert", "plate armor" };

        //constructor
        public Armor(string _name)
        {
            name = _name;
            AssignStats();
        }

        //To give an item its stats
        private void AssignStats()
        {
            if (name == "cloak")
            {
                value = 10;
                defense = 5;
            }
            else if (name == "gambison")
            {
                value = 25;
                defense = 10;
            }
            else if (name == "haubert")
            {
                value = 50;
                defense = 25;
            }
            else if (name == "plate armor")
            {
                value = 200;
                defense = 50;
            }
        }
    }
}
