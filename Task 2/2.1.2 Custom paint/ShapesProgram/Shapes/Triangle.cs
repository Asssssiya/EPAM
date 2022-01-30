using System;
using System.Linq;
using System.Numerics;

namespace ShapesProgram.Shapes
{
    public class Triangle : Shape
    {
        private double[] _sides;

        public Triangle(Vector2 position, double[] sides) : base(position)
        {
            const int edgesCount = 3;

            if (sides.Length != edgesCount)
                throw new ArgumentException(nameof(sides));

            _sides = new double[edgesCount];
            Array.Copy(sides, _sides, edgesCount);
        }

        public override double Area => GetArea();

        public override double Perimeter => _sides.Sum();

        private double GetArea()
        {
            double a = _sides[0];
            double b = _sides[1];
            double c = _sides[2];

            double semiPerimeter = Perimeter / 2.0;
            return Math.Sqrt(
                semiPerimeter * 
                (semiPerimeter - a) *
                (semiPerimeter - b) *
                (semiPerimeter - c)
                );
        }
    }
}
