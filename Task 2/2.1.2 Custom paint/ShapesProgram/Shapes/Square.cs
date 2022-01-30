using System.Numerics;

namespace ShapesProgram.Shapes
{
    public class Square : Rectangle
    {
        public double Size => Width;

        public Square(Vector2 position, double size) : base(position, size, size)
        {
        }
    }
}
