using System.Numerics;

namespace ShapesProgram.Shapes
{
    // нельзя наследовать Circle от Ball,
    // так как у Ball площадь зависит от радиуса,
    // а у Circle она константная
    // При таком наследовании нарушается принцип LSP, 
    // ведь такой тест Assert.AreEqual(ball.Area, 2 * Math.Pi * radius)
    // может не пройти, ведь в Ball мы можем запихнуть Circle
    public class Circle : CircularShape
    {
        public Circle(Vector2 position, double radius) : base(position, radius)
        {
        }

        public override double Area => 0;
    }
}
