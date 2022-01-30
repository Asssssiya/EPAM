using GameProgram.Game.Bonuses;
using System;

namespace GameProgram.Game
{
    public class Player : MoveableObject
    {
        private int _health;
        public event Action Dead;
        public Player(int health)
        {
            _health = health;
        }
        public void PickUp(Bonus bonus)
        {
            bonus.Influence(this);
            bonus.Destroy();
        }

        public void TakeDamage()
        {
            _health--;

            if (_health <= 0)
            {
                Dead?.Invoke();
            }
        }
         
        public void Heal()
        {
            _health++;
            
        }
    }
}
