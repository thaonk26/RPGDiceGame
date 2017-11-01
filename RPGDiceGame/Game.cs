using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDiceGame
{
    public class Game
    {
        public Game()
        {

        }
        private string playerName;

        public void GameStart()
        {
            playerName = new MainPhase().Welcome();
            Player player = new Player(playerName);
            BattlePhase bp = new BattlePhase();
            int atkdmg;
            while (player.IsAlive())
            {
                player.DisplayHealth(true);
                atkdmg = bp.Attack();
                player.currentHealth -= atkdmg;
                Console.WriteLine(string.Format("You have been attacked for : {0}", atkdmg));
                if (player.currentHealth <= 0)
                    break;
                player.DisplayHealth();
                Console.ReadLine();

            }
            Console.WriteLine(string.Format("{0} has died....Goodbye", playerName));
            Console.ReadLine();
        }

        
    }
}
