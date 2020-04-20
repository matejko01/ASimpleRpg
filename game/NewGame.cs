using ASimpleRpg.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.game
{
    class NewGame
    {


        public void createNewCharacter()
        {
            Console.Clear();
            Player player = new Player(true, "", 0, 0);
            player.Create();

            Console.Clear();
            player.PresentYourself();
        }
    }


}
