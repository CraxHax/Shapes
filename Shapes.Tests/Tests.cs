using Shapes.Base;

namespace Shapes.Tests
{
    public class Tests
    {
        static object[] RadiusesAndAreas =
        {
            new object[] { 1d, Constants.PI },
            new object[] { 4d, 16d * Constants.PI },
            new object[] { 10d / 3d, Constants.PI * (10d / 3d) * (10d / 3d) },
            new object[] { 10d / 3d, 100d / 9d * Constants.PI }
        };
        static object[] Triangles =
        {
            new object[] { 3,4,5, true, 12},
            new object[] { 4,5,2, false, 3.7996710383926659079171860515099d},
            new object[] { 13,5,12, true, 60},
            new object[] { 4,4,4, false, 6.9282032302755091741097853660235d}
        };
        static object[] Shapes =
        {
            new object[] { new Circle(1d), Constants.PI },
            new object[] { new HeronTriangle(3, 4, 5), 12 },
            new object[] { new Circle(10d / 3d), Constants.PI * (10d / 3d) * (10d / 3d) },
            new object[] { new HeronTriangle(4, 5, 2), 3.7996710383926659079171860515099d },

        };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(nameof(RadiusesAndAreas))]
        public void CircleAreaTest(double r, double result)
        {
            
            IShape area = new Circle(r);

            Assert.True(Helpers.AreEqual(area.GetArea(), result));
        }

        [Test]
        [TestCaseSource(nameof(Triangles))]
        public void TriangleAreaTest(double a, double b, double c, bool isRight, double result)
        {
            HeronTriangle triangle = new HeronTriangle(a, b, c);

            Assert.That(isRight, Is.EqualTo(triangle.IsRight()));
            Assert.That(Helpers.AreEqual(triangle.GetArea(), result));
        }

        [Test]
        [TestCaseSource(nameof(Shapes))]
        public void AreaTest(IShape shape, double result)
        {
            Assert.True(Helpers.AreEqual(shape.GetArea(), result));
        }
    }
}