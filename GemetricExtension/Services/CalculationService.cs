using System;
using GeometricExtension.Interfaces;
using GeometricExtension.Models;

namespace GeometricExtension.Services
{
    /// <summary>
    /// Производит расчет площади геометрических фигур
    /// </summary>
    public class CalculationService : Interfaces.GeometricExtension
    {
        /// <inheritdoc/>
        public GeometricFigure CalculateFigureArea(params double[] figureParameters)
        {
            switch (figureParameters.Length)
            {
                case 1:
                    double circleArea = CalculateAreaOfCircle(figureParameters[0]);
                    return new CalculatedCircle(circleArea);
                case 3:
                    double triangleArea = CalculateAreaOfTriangle(
                        figureParameters[0], figureParameters[1], figureParameters[2]);
                    return new CalculatedTriangle(triangleArea);
                default:
                    throw new ArgumentException(
                        "Неверное количество аргументов. Допустимо 1, или 3 аргумента в зависимости от типа фигуры");
            }
        }

        /// <inheritdoc/>
        public CalculatedCircle CalculateCircleArea(double radius)
        {
            double area = CalculateAreaOfCircle(radius);
            return new CalculatedCircle(area);
        }

        /// <inheritdoc/>
        public CalculatedCircle CalculateCircleArea(CircleForCalculation circleParameters)
        {
            double area = CalculateAreaOfCircle(circleParameters.Radius);
            return new CalculatedCircle(area);
        }

        /// <inheritdoc/>
        public CalculatedTriangle CalculateTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            double area = CalculateAreaOfTriangle(firstSide, secondSide, thirdSide);
            return new CalculatedTriangle(area);
        }

        /// <inheritdoc/>
        public CalculatedTriangle CalculateTriangleArea(TriangleForCalculate triangleParameters)
        {
            double area = CalculateAreaOfTriangle(
                triangleParameters.FirstSide, triangleParameters.SecondSide, triangleParameters.ThirdSide);
            return new CalculatedTriangle(area);
        }

        /// <summary>
        /// Произвести вычисление площади круга, передав его радиус
        /// </summary>
        private double CalculateAreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Произвести вычисление площади треугольника, передав длины его сторон
        /// </summary>
        private double CalculateAreaOfTriangle(double firstSide, double secondSide, double thirdSide)
        {
            double perimeter = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));
        }
    }
}
