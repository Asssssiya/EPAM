using GameProgram.Game.Core;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace GameProgram.Game
{
    public abstract class MoveableObject : GameObject
    {
      

        public void Move(Vector2 direction)
        {
            throw new NotImplementedException();
        }
    }
}
