using System;

namespace CalulateArea
{
    public class Triangle : Shape
    {
        public override double CalculateArea(double @base, double height)
        {
            if ((@base <= 0) || (height <= 0))
                return 0;
            else
            {
                result = (@base * height) / 2;
                return result;
            }
        }
        public override double CalculateArea(double side1, double side2, double side3)
        {
            if ((side1 <= 0) || (side2 <= 0) || (side3 <= 0))
                return 0;
            else if ((side1 + side2) > side3 && (side1 + side3) > side2 && (side2 + side3) > side1)
            {
                double perimeter = (side1 + side2 + side3) / 2;
                result = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
                return result;
            }
            else
                return 0;
        }
    }
}
