using System;
using System.Collections.Generic;
using System.Text;

namespace ASimpleRpg.game
{
    class MainMenu
    {
        public void Display()
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("##       ##    ###     #### ##     ##     ##       ## ######## ##     ## ##       ##");
            Console.WriteLine("###     ###   ##  ##    ##  ###    ##     ###     ### ##       ###    ## ##       ##");
            Console.WriteLine("####   ####  ##    ##   ##  #####  ##     ####   #### ##       ####   ## ##       ##");
            Console.WriteLine("##  ###  ## ##      ##  ##  ## ### ##     ##  ###  ## ######## ## ### ## ##       ##");
            Console.WriteLine("##       ## ##########  ##  ##   ####     ##       ## ##       ##   #### ##       ##");
            Console.WriteLine("##       ## ##      ##  ##  ##    ###     ##       ## ##       ##    ###  ##     ## ");
            Console.WriteLine("##       ## ##      ## #### ##     ##     ##       ## ######## ##     ##    #####");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n1) New game\n2) Load game\n3) Exit");
        }
    }
}
