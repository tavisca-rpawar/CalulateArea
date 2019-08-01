namespace CalulateArea
{
    public class Shape
    {
        public double result;
        public virtual double CalculateArea(double sideA)
        { return 0; }
        public virtual double CalculateArea(double sideA, double sideB)
        { return 0; }
        public virtual double CalculateArea(double sideA, double sideB, double sideC)
        { return 0; }
    }
}
