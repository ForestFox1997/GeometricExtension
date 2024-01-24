using GeometricExtension.Services;
using GeometricExtension.Models;
using GeometricExtension.Interfaces;

CalculationService _geometricService = new();

Console.WriteLine("Демонстрация использования GeometricExtension");

while (!Console.KeyAvailable)
{
    Console.WriteLine("Нажмите C для расчета площади круга, T для расчета площади " +
        "треугольника, или нажмите ENTER, чтобы ввести значения фигуры без указания ее типа");
    Console.WriteLine("Для выхода нажмите ESC");

    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

    // Circle area
    if (keyInfo.Key == ConsoleKey.C)
    {
        Console.WriteLine("Расчет площади круга. Укажите радиус для расчета:");

        double radius;
        while (!double.TryParse(Console.ReadLine(), out radius))
        {
            Console.WriteLine("Введенное значение не является числом, повторите ввод");
        }
        CalculatedCircle circle = _geometricService.CalculateCircleArea(radius);

        Console.WriteLine("Площадь круга составляет: {0}", circle.FigureArea);
    }
    // Triangle area
    else if (keyInfo.Key == ConsoleKey.T)
    {
        Console.WriteLine("Расчет площади треугольника. Укажите длины трех сторон через запятую:");

        bool valuesReceived = false;
        List<double> numbers = new();
        while (!valuesReceived)
        {
            string[] values = Console.ReadLine()!.Split(',');
            if (values.Length != 3)
            {
                Console.WriteLine("Необходимо ввести три числовых значения через запятую");
                continue;
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (!double.TryParse(values[i], out double value))
                {
                    Console.WriteLine("Необходимо ввести три числовых значения через запятую");
                    break;
                }
                numbers.Add(value);
            }

            if (numbers.Count == 3)
            {
                valuesReceived = true;
            }
        }

        CalculatedTriangle triangle = _geometricService.CalculateTriangleArea(numbers[0], numbers[1], numbers[2]);
        Console.WriteLine("Площадь треугольника составляет: {0}, треугольник {1}",
            triangle.FigureArea, triangle.IsRightTriangle ? "прямоугольный" : "непрямоугольный");
    }
    // Free figure choice
    else if (keyInfo.Key == ConsoleKey.Enter)
    {
        Console.WriteLine("Для автоматического определения фигуры укажите ее параметры через запятую");

        string[] values = Console.ReadLine()!.Split(',');
        var numbers = new double[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            if (!double.TryParse(values[i], out _))
            {
                Console.WriteLine("Допустим ввод одного или трех числовых значений через запятую");
                break;
            }

            numbers[i] = double.Parse(values[i]);
        }

        try
        {
            GeometricFigure figure = _geometricService.CalculateFigureArea(numbers);
            string additionalInformation = "";
            if (figure is CalculatedTriangle calculatedTriangle)
            {
                additionalInformation = calculatedTriangle.IsRightTriangle
                    ? "Треугольник прямоугольный"
                    : "Треугольник непрямоугольный";
            }

            Console.WriteLine("Площадь фигуры {0} составляет {1}; {2}",
                figure.FigureType, figure.FigureArea, additionalInformation);
        }
        catch
        {
            Console.WriteLine("Ошибка вычисления, убедитесь, что указано только 1, или 3 значения через запятую");
        }
    }
    // Exit
    else if (keyInfo.Key == ConsoleKey.Escape)
    {
        break;
    }
}
