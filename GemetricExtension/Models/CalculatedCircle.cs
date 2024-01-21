using GeometricExtension.Enums;
using GeometricExtension.Interfaces;
using System;

namespace GeometricExtension.Models
{
    /// <summary>
    /// Круг с рассчитанной площадью
    /// </summary>
    public class CalculatedCircle : GeometricFigure
    {
        /// <inheritdoc cref="CalculatedCircle"/>
        public CalculatedCircle(double circleArea)
        {
            FigureArea = circleArea;
        }

        /// <inheritdoc/>
        public Figure FigureType => Figure.Circle;

        /// <inheritdoc/>
        public double FigureArea { get; }
    }
}
