using ASimpleRpg.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.game
{
    class RecruitStory
    {
        //The main story, chapters will be added here
        public void TellAStory()
        {
            CreateCharacter();
        }

        //Creates player's character
        private void CreateCharacter()
        {
            Player player = new Player(true, "", "recruit", 0, 0, 0);
            player.Create();
            player.PresentYourself();
        }
    }
}
