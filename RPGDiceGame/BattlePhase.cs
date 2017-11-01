using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDiceGame
{
    public class BattlePhase
    {
        Dice d12 = new Dice(12);
        private int dmg;
        public BattlePhase()
        {

        }
        public int Attack()
        {
            dmg = d12.RollDice();
            CriticalAttack();
            return dmg;
        }
        private void CriticalAttack()
        {
            int crit = d12.RollDice();
            if (crit % 4 == 0)
            {
                dmg += crit;
                Console.WriteLine(string.Format("CRIT!!: {0}", crit));
            }
        }

    }
}
