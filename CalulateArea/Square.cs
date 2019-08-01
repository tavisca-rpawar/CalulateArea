namespace CalulateArea
{
    public class Square : Shape
    {
        public override double CalculateArea(double sides)
        {
            if (sides <= 0)
                return 0;
            else
            {
                result = sides * sides;
                return result;
            }
        }
    }
}
