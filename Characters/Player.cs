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

        public int vigor { get; set; }
        public int cunning { get; set; }


        //constructor
        public Player(bool _isMale, string _name, int _vigor, int _cunning)
        {
            isMale = _isMale;
            name = _name;
            vigor = _vigor;
            cunning = _cunning;
        }


        //Player creates his character
        public void Create()
        {
            //Variables that check if player's input is correct
            bool nameInput = true;
            bool genderInput = true;
            bool professionInput = true;

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
                    vigor = 10;
                    cunning = 5;
                    genderInput = false;
                }
                else if (isMaleAnswer == "2")
                {
                    isMale = false;
                    vigor = 5;
                    cunning = 10;
                    genderInput = false;
                }
                else
                {
                    Console.Clear();
                }
            } while (genderInput);

            do
            {
                Console.Clear();
                Console.WriteLine("What is your profession? \n1)Recruit \n2)Pickpocket \n3)Acolyte");
                string professionGiven = Console.ReadLine();

                if (professionGiven == "1")
                {
                    profession = "recruit";
                    vigor += 45;
                    cunning += 15;
                    professionInput = false;
                }
                else if (professionGiven == "2")
                {
                    profession = "pickpocket";
                    vigor += 30;
                    cunning += 30;
                    professionInput = false;
                }
                else if (professionGiven == "3")
                {
                    profession = "acolyte";
                    vigor += 45;
                    cunning += 15;
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
            int dmg = this.cunning * weaponValue;
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

            Console.WriteLine("My name is {0}, I have vigor of {1}, cunning of {2}, and I am a {3} {4}", name, vigor, cunning, gender, profession);
        }
    }
}
