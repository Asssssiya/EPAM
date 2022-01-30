using System.Numerics;

namespace GameProgram.Game.Core
{
    public class Transform
    {
        public Vector2 Position;
        public double RotationAngle;
        public Vector2 Scale;

        public Transform()
        {
            Position = new Vector2();
            RotationAngle = 0;
            Scale = Vector2.One;
        }
    }
}
