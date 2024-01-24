using GeometricExtension.Enums;
using GeometricExtension.Interfaces;

namespace GeometricExtension.Models
{
    /// <summary>
    /// Треугольник для расчета его площади
    /// </summary>
    public class CalculatedTriangle : GeometricFigure
    {
        /// <inheritdoc cref="CalculatedTriangle"/>
        public CalculatedTriangle(double area, bool isRightTriangle)
        {
            FigureArea = area;
            IsRightTriangle = isRightTriangle;
        }

        /// <inheritdoc/>
        public Figure FigureType => Figure.Triangle;

        /// <inheritdoc/>
        public double FigureArea { get; }

        /// <summary>
        /// Является прямоугольным
        /// </summary>
        public bool IsRightTriangle { get; }
    }
}
