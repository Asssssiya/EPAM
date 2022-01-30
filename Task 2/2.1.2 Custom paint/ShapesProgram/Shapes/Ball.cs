using System;
using System.Numerics;

namespace ShapesProgram.Shapes
{
    public class Ball : CircularShape
    {
        public Ball(Vector2 position, double radius) : base(position, radius)
        {
        }

        public override double Area => Math.PI * Radius;
    }
}
