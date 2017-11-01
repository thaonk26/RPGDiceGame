using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDiceGame
{
    public class MainPhase
    {
        private string playerName;
        public MainPhase()
        {

        }

        public string Welcome()
        {
           return playerName = new Messages().WelcomeMessage();
        }

    }
}
