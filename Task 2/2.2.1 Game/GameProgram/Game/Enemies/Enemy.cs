using GameProgram.Game;

namespace GameProgram.Game.Enemies
{
    public abstract class Enemy : MoveableObject
    {
        protected double Strength { get; set; }

        public void Attack(Player player)
        {
            player.TakeDamage();
            Destroy();

        }

    }
}
