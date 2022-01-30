using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram.Shapes
{
    public abstract class CircularShape : Shape
    {
        public double Radius { get; private set; }

        public CircularShape(Vector2 position, double radius) : base(position)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            Radius = radius;
        }

        public override double Perimeter => 2 * Math.PI * Radius;
    }
}
