
using System.Numerics;

namespace ShapesProgram.Shapes
{
    public abstract class Shape
    {
        protected Vector2 Position;

        public Shape(Vector2 position)
        {
            Position = position;
        }

        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public override string ToString()
        {
            return $"{GetType().Name}: Координаты центра {Position} \n| Площадь {Area} \n| Периметр {Perimeter}";
        }
    }
}
