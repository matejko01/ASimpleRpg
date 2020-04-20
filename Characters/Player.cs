using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.Characters
{
    public class Player
    {
        //variables
        public bool isMale { get; set; }
        public string name { get; set; }
        public string profession { get; set; }

        public int health { get; set; }
        public int skill { get; set; }


        //Object's constructor
        public Player(bool _isMale, string _name, int _health, int _skill)
        {
            isMale = _isMale;
            name = _name;
            health = _health;
            skill = _skill;
        }


        //A player creates his character
        public void Create()
        {
            bool nameInput = true;
            do
            {
                Console.Clear();
                Console.WriteLine("What is your name:");
                name = Console.ReadLine();

                if (name == "")
                {
                    Console.Clear();
                }
                else
                {
                    nameInput = false;
                }
            }
            while (nameInput);

            bool genderInput = true;
            do
            {
                Console.Clear();
                Console.WriteLine("What is your gender? \n1) male \n2)female");
                string isMaleAnswer = Console.ReadLine();

                if (isMaleAnswer == "1")
                {
                    isMale = true;
                    genderInput = false;
                }
                else if (isMaleAnswer == "2")
                {
                    isMale = false;
                    genderInput = false;
                }
                else
                {
                    Console.Clear();
                }
            } while (genderInput);

            bool professionInput = true;
            do
            {
                Console.Clear();
                Console.WriteLine("What is your profession? \n1)Squire \n2)Pickpocket \n3)Page");
                string professionGiven = Console.ReadLine();

                if (professionGiven == "1")
                {
                    profession = "squire";
                    professionInput = false;
                }
                else if (professionGiven == "2")
                {
                    profession = "pickpocket";
                    professionInput = false;
                }
                else if (professionGiven == "3")
                {
                    profession = "page";
                    professionInput = false;
                }
                else
                {
                    Console.Clear();
                }
            }
            while (professionInput);
        }

        //Below there will be abilities
        public int MeleeAttack()
        {
            int weaponValue = 3;
            int dmg = this.skill * weaponValue;
            return dmg;
        }


        //Just to see if it works
        public void PresentYourself()
        {
            string gender;

            if (isMale)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            Console.WriteLine("My name is {0}, I have health of {1}, skill of {2}, and I am a {3} {4}", name, health, skill, gender, profession);
        }
    }
}
