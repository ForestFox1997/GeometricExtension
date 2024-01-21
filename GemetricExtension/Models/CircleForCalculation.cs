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

        public double Radius { get; }
    }
}
