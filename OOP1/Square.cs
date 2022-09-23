namespace OOP1
{
    public class Square : Figure
    {
        double x;
        public Square(double x)
        {
            this.x = x;
        }
        public override double Area()
        {
            return x * x;
        }
    }
}