using Xunit;
using MyGeometryLibrary.Shapes;
using MyGeometryLibrary.Utils;

namespace MyGeometryLibrary.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.Equal(Math.PI * 25, circle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 5);
        }

        [Fact]
        public void TriangleIsRightAngledTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void CalculateShapeAreaTest()
        {
            IShape circle = new Circle(5);
            IShape triangle = new Triangle(3, 4, 5);

            Assert.Equal(Math.PI * 25, ShapeUtils.CalculateShapeArea(circle), 5);
            Assert.Equal(6, ShapeUtils.CalculateShapeArea(triangle), 5);
        }
    }
}
