namespace TestProject.FigureCalculating.Models
{
    public class Triangle : Figure
    {
        public Int32 FirstSide { get; }
        public Int32 SecondSide { get; }
        public Int32 ThirdSide { get; }

        public Triangle(Int32 firstSide, Int32 secondSide, Int32 thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public Double GetSquare()
        {
            CheckResult result = IsRightTriangle();
            if (result.isRightTriangle)
            {
                return Math.Round(0.5 * (result.Catet1 * result.Catet2), 2);
            }

            Double PoluPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Round(Math.Sqrt(PoluPerimeter * (PoluPerimeter - FirstSide)
                * (PoluPerimeter - SecondSide)
                * (PoluPerimeter - ThirdSide)), 2);
        }

        private CheckResult IsRightTriangle()
        {
            if (Math.Pow(FirstSide, 2) == (Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2)))
                return new(true, SecondSide, ThirdSide);

            if (Math.Pow(SecondSide, 2) == (Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2)))
                return new(true, FirstSide, ThirdSide);

            if (Math.Pow(ThirdSide, 2) == (Math.Pow(SecondSide, 2) + Math.Pow(FirstSide, 2)))
                return new(true, SecondSide, FirstSide);

            return new(false, 0, 0);
        }

        record CheckResult(Boolean isRightTriangle, Double Catet1, Double Catet2);
    }
}
