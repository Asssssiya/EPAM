using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgram.Game.Bonuses
{
    public class Apple : Bonus
    {
        public override void Influence(Player player)
        {
            player.Heal();
        }
    }
}
