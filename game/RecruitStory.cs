using ASimpleRpg.Characters;
using ASimpleRpg.Locations;
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
            SpawnMonster();
            GenerateDungeon();
        }

        //Creates player's character
        private void CreateCharacter()
        {
            Player player = new Player(true, "", "recruit", 0, 0, 0);
            player.Create();
            player.PresentYourself();
        }

        //Generates a monster
        private void SpawnMonster()
        {
            Monster monster = new Monster("", "", 0, 0);
            monster.GenerateMonster();
            monster.PresentYourself();
        }

        //Generates a dungeon object
        private void GenerateDungeon()
        {
            Dungeon dungeon = new Dungeon();
            Console.WriteLine(dungeon.someObject);
        }
    }
}
