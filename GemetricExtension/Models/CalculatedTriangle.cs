using GeometricExtension.Enums;
using GeometricExtension.Interfaces;
using System;

namespace GeometricExtension.Models
{
    /// <summary>
    /// Треугольник для расчета его площади
    /// </summary>
    public class CalculatedTriangle : GeometricFigure
    {
        /// <inheritdoc cref="CalculatedTriangle"/>
        public CalculatedTriangle(double area)
        {
            FigureArea = area;
        }

        /// <inheritdoc/>
        public Figure FigureType => Figure.Triangle;

        /// <inheritdoc/>
        public double FigureArea { get; }
    }
}
