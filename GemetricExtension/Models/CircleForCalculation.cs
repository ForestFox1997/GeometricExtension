namespace GeometricExtension.Models
{
    /// <summary>
    /// Круг для расчета площади
    /// </summary>
    public class CircleForCalculation
    {
        /// <inheritdoc cref="CircleForCalculation"/>
        /// <param name="radius">Радиус круга</param>
        public CircleForCalculation(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        public double Radius { get; }
    }
}
