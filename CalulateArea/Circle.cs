namespace CalulateArea
{
    public class Circle : Shape
    {
        public override double CalculateArea(double radius)
        {
            if (radius <= 0)
                return 0;
            else
            {
                result = 3.14 * radius * radius;
                return result;
            }
        }
    }
}
