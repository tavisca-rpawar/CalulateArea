using CalulateArea;
using Xunit;

namespace CalculateAreaTests
{
    public class CalculateAreaFixture
    {
        [Fact]
        public void DummyTest()
        {
            return;
        }
        [Theory]
        [InlineData(100, 314)]
        [InlineData(0.0, 0)]
        [InlineData(-11.0, 0)]

        public void Circle_area_test(double radius, double expected)
        {
            Shape circle = new Circle();
            circle.CalculateArea(radius).Equals(expected);
        }

        [Theory]
        [InlineData(10,20.8, 200.8)]
        [InlineData(0.0, -10, 0)]

        public void Rectangle_area_test(double lenght,double breadth, double expected)
        {
            Shape rectangle = new Rectangle();
            rectangle.CalculateArea(lenght, breadth).Equals(expected);
        }

        [Theory]
        [InlineData(19.7,388.09)]
        [InlineData(-10, 0)]
        public void Square_area_test(double sides, double expected)
        {
            Shape square = new Rectangle();
            square.CalculateArea(sides).Equals(expected);
        }

        [Theory]
        [InlineData(19.7, 2, 19.7)]
        [InlineData(-10, 0, 0)]
        public void Triangle_area_having_base_and_height_test(double @base, double height, double expected)
        {
            Shape triangle = new Rectangle();
            triangle.CalculateArea(@base, height).Equals(expected);
        }

        [Theory]
        [InlineData(2, 4, 3, 6)]
        [InlineData(10, 5.7, 15,16.65)]
        [InlineData(-10, 5.7, 0, 0)]

        public void Triangle_area_with_three_sides_test(double side1, double side2, double side3, double expected)
        {
            Shape triangle = new Rectangle();
            triangle.CalculateArea(side1,side2,side3).Equals(expected);
        }
    }
}
