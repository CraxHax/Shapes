using Shapes.Base;

namespace Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Constants.PI * Radius * Radius;
        }
    }
}