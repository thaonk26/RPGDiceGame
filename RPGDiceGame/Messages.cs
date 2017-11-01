using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDiceGame
{
    public class Messages
    {
        public Messages()
        {

        }

        public string WelcomeMessage()
        {
            Console.WriteLine("Welcome to my game");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            return name;
        }



    }
}
