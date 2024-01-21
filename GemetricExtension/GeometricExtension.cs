using GeometricExtension.Interfaces;
using GeometricExtension.Models;

namespace GeometricExtension
{
    /// <summary>
    /// Представляет возможность вычисления площади круга по радиусу и треугольника по трем его сторонам
    /// </summary>
    public interface GeometricExtension
    {
        /// <summary>
        /// Вычисляет площадь геометрической фигуры по длине геометрических величин этой фигуры
        /// </summary>
        /// <param name="figureParameters">Одно, или три числовых значения:
        /// длина радиуса круга, или длины сторон треугольника</param>
        /// <remarks>
        /// В текущей версии библиотеки поддерживается вычисление площади
        /// круга по его радиусу, либо треугольника по его сторонам
        /// </remarks>
        GeometricFigure CalculateFigureSquare(params double[] figureParameters);

        /// <summary>
        /// Возвращает площадь круга по переданному радиусу этого круга
        /// </summary>
        CalculatedCircle CalculateCircleSquare(double radius);

        /// <summary>
        /// Возвращает площадь круга по переданному радиусу этого круга
        /// </summary>
        CalculatedCircle CalculateCircleSquare(CircleForCalculation circleParameters);

        /// <summary>
        /// Возвращает площадь треугольника по трем переданным сторонам этого треугольника
        /// </summary>
        CalculatedTriangle CalculateTriangleSquare(double firstSide, double secondSide, double thirdSide);

        /// <summary>
        /// Возвращает площадь треугольника по трем переданным сторонам этого треугольника
        /// </summary>
        CalculatedTriangle CalculateTriangleSquare(TriangleForCalculate triangleParameters);
    }
}
