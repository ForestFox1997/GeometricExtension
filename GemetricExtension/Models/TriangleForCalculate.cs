namespace GeometricExtension.Models
{
    /// <summary>
    /// Треугольник с рассчитанной площадью
    /// </summary>
    public class TriangleForCalculate
    {
        /// <inheritdoc cref="TriangleForCalculate"/>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        public TriangleForCalculate(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double FirstSide { get; set; }

        public double SecondSide { get; set; }

        public double ThirdSide { get; set; }
    }
}
