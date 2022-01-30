using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram.Shapes
{
    public class Ring : Shape
    {
        private Ball _innerBall;
        private Ball _outerBall;

        public Ring(Vector2 position, double innerRadius, double outerRadius) : base(position)
        {
            if (innerRadius > outerRadius)
                throw new ArgumentException(nameof(innerRadius), nameof(outerRadius));

            _innerBall = new Ball(position, innerRadius);
            _outerBall = new Ball(position, outerRadius);
        }

        public override double Area => _outerBall.Area - _innerBall.Area;
        public override double Perimeter => _outerBall.Perimeter + _innerBall.Perimeter;
    }
}
