using GeometricExtension.Models;

namespace GeometricExtension.Interfaces
{
    /// <summary>
    /// Представляет возможность вычисления площади круга по радиусу и треугольника по трем его сторонам
    /// </summary>
    public interface IGeometricExtension
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
        GeometricFigure CalculateFigureArea(params double[] figureParameters);

        /// <summary>
        /// Возвращает площадь круга по переданному радиусу этого круга
        /// </summary>
        CalculatedCircle CalculateCircleArea(double radius);

        /// <summary>
        /// Возвращает площадь круга по переданному радиусу этого круга
        /// </summary>
        CalculatedCircle CalculateCircleArea(CircleForCalculation circleParameters);

        /// <summary>
        /// Возвращает площадь треугольника по трем переданным сторонам этого треугольника
        /// </summary>
        CalculatedTriangle CalculateTriangleArea(double firstSide, double secondSide, double thirdSide);

        /// <summary>
        /// Возвращает площадь треугольника по трем переданным сторонам этого треугольника
        /// </summary>
        CalculatedTriangle CalculateTriangleArea(TriangleForCalculate triangleParameters);
    }
}
