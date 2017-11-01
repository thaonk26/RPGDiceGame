using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGDiceGame
{
    public class Game
    {
        public Game()
        {

        }
        private string playerName;

        BattlePhase bp = new BattlePhase();
        int atkdmg;
        public void GameStart()
        {
            playerName = new MainPhase().Welcome();
            Player player = new Player(playerName);
            Thread.Sleep(500);
            Player cpu = new Player("CPU");
            while (player.IsAlive())
            {
                PlayerTurn(player, cpu);

                if (cpu.currentHealth <= 0)
                    break;
                Console.ReadLine();
                PlayerTurn(cpu, player);
                if (player.currentHealth <= 0)
                    break;
                Console.ReadLine();
            }
            if(player.currentHealth <=0)
                Console.WriteLine(string.Format("{0} has died....You LOSE!", playerName));
            else
                Console.WriteLine(string.Format("{0} has died....You WIN!!", "CPU"));
            Console.ReadLine();
        }
        private void PlayerTurn(Player player, Player player2)
        {
            player2.DisplayHealth(true);
            atkdmg = bp.Attack();
            Console.WriteLine(string.Format("{1} attacked {2} : {0}", atkdmg, player.PlayerName, player2.PlayerName));
            player2.currentHealth -= atkdmg;
            player2.DisplayHealth();
        }
        
    }
}
