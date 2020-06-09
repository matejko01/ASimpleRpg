using ASimpleRpg.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.game
{
    class NewGame
    {
        public void Start()
        {
            SelectAdventure();
        }

        //Player chooses his profession
        private void SelectAdventure()
        {
            bool professionInput = true;
            do
            {
                Console.Clear();
                Console.WriteLine("What is your profession? \n1)Recruit \n2)Pickpocket \n3)Acolyte");
                string professionGiven = Console.ReadLine();

                if (professionGiven == "1")
                {
                    StartRecruitStory();
                    professionInput = false;
                }
                else if (professionGiven == "2")
                {
                    Console.WriteLine("This would start a pickpocket story");
                    professionInput = false;
                }
                else if (professionGiven == "3")
                {
                    Console.WriteLine("This would start an acolyte story");
                    professionInput = false;
                }
                else
                {
                    Console.Clear();
                }
            }
            while (professionInput);
        }

        //Methods that will provide a proper story
        private void StartRecruitStory()
        {
            RecruitStory recruitStory = new RecruitStory();
            recruitStory.TellAStory();
        }
    }


}
