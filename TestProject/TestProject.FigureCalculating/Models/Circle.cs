namespace TestProject.FigureCalculating.Models
{
    public class Circle : Figure
    {
        public Int32 Radius { get; }

        public Circle(Int32 radius )
        {
            Radius = radius;
        }

        public Double GetSquare()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }
    }
}
