using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.Characters
{
    public class Player
    {
        //properties
        public bool isMale { get; set; }
        public string name { get; set; }
        public string profession { get; set; }

        public int attack { get; set; }
        public int charisma { get; set; }
        public int health { get; set; }


        //constructor
        public Player(bool _isMale, string _name, string _profession, int _attack, int _charisma, int _health)
        {
            isMale = _isMale;
            name = _name;
            profession = _profession;
            attack = _attack;
            charisma = _charisma;
            health = _health;
        }


        //Player creates his character
        public void Create()
        {
            //Variables that check if player's input is correct
            bool nameInput = true;
            bool genderInput = true;
            

            //Provide character's info
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

            do
            {
                Console.Clear();
                Console.WriteLine("What is your gender? \n1) male \n2)female");
                string isMaleAnswer = Console.ReadLine();

                if (isMaleAnswer == "1")
                {
                    isMale = true;
                    attack = 10;
                    charisma = 5;
                    genderInput = false;
                }
                else if (isMaleAnswer == "2")
                {
                    isMale = false;
                    attack = 5;
                    charisma = 10;
                    genderInput = false;
                }
                else
                {
                    Console.Clear();
                }
            } while (genderInput);

            //Assign class properties
            if (profession == "recruit")
            {
                CreateRecruit();
            }
            else if (profession == "pickpocket")
            {
                CreatePickpocket();
            }
            else
            {
                CreateAcolyte();
            }
        }

        //Class creation
        private void CreateRecruit()
        {
            attack += 45;
            charisma += 15;
            health = 100;
        }

        private void CreatePickpocket()
        {
            attack += 30;
            charisma += 30;
            health = 100;
        }

        private void CreateAcolyte()
        {
            attack += 15;
            charisma += 45;
            health = 100;
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

            Console.WriteLine("My name is {0}, I have attack of {1}, charisma of {2}, and I am a {3} {4}. Also, I have {5} health.", name, attack, charisma, gender, profession, health);
        }


    }
}
