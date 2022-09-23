namespace OOP1
{
    public class Circle : Figure

    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            return 3.14 * r * r;
        }
    }
}