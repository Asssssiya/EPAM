using System;

using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProgram.Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(Vector2 position, double width, double height) : base(position)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException(nameof(width), nameof(height));

            Width = width;
            Height = height;
        }

        public override double Area => Width * Height;

        public override double Perimeter => 2 * (Width + Height);
    }
}
