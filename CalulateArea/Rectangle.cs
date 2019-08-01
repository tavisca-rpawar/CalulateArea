namespace CalulateArea
{
    public class Rectangle : Shape
    {
        public override double CalculateArea(double length, double breadth)
        {
            if ((length <= 0) || (breadth <= 0))
                return 0;
            else
            {
                result = length * breadth;
                return result;
            }
        }
    }
}
