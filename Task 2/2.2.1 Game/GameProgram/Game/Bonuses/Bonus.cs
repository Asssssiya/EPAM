using GameProgram.Game.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgram.Game.Bonuses
{
    public abstract class Bonus : GameObject
    {
        public abstract void Influence(Player player);

        
    }
}
