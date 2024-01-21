using GeometricExtension.Enums;

namespace GeometricExtension.Interfaces
{
    /// <summary>
    /// Представляет параметры геометрической фигуры
    /// </summary>
    public interface GeometricFigure
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        Figure FigureType { get; }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        double FigureSquare { get; }
    }
}
