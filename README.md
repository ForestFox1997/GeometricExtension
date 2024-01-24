# GemetricExtension

Представляет собой .NET Standart библиотеку, представляющую функциональность расчета площади
геометрических фигур по их переданным параметрам.

В текущей версии поддерживается:
 * Расчет площади круга по переданному значению его радиуса
 * Расчет площади треугольника по переданным длинам его сторон, определение яв-ся ли треугольник
 прямоугольным

Компоненты программного решения:
 * _GeometricExtension_ - ядро решения, библиотека компонуемая в Nuget пакет
 * _GeometricExtensionDemo_ - CLI приложение, демонстрирующее использование библиотеки
 * _Tests_ - проект, содержащий unit тесты, проверяющие функциональность, отвечающую за вычисления

 Зависимости:
 * .NET Standart 2.0 совместимый SDK для сборки _GeometricExtension_
 * .NET 6.0 SDK для сборки _GeometricExtensionDemo_, _Tests_

 Пример использвания:
``` C#
using GeometricExtension.Services;
using GeometricExtension.Models;

// Создаем экземпляр сервиса вычисления
CalculationService _geometricService = new();

// Расчитываем площадь треугольника, где 5, 6, 7 - его стороны
CalculatedTriangle triangle = _geometricService.CalculateTriangleArea(5, 6, 7);

// Делаем вывод результата на консоль
Console.WriteLine("Площадь треугольника составляет: {0}, треугольник {1}",
    triangle.FigureArea, triangle.IsRightTriangle ? "прямоугольный" : "непрямоугольный");
```
