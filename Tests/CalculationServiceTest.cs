using System.Reflection;
using static System.Math;
using GeometricExtension.Services;

namespace Tests
{
    /// <summary>
    /// Тестирует функциональность <see cref="CalculationService"/>
    /// </summary>
    [TestClass]
    public class CalculationServiceTest
    {
        /// <summary>
        /// Проверяет <see cref="CalculationService.CalculateFigureArea"/>, принимающий произвольное кол-во
        /// аргументов на выброс исключения, если кол-во переданных аргументов оказалось некорректно
        /// </summary>
        [TestMethod]
        public void CheckInterruptWhenIncorrectArgumentsNumber()
        {
            CalculationService service = new();

            // Ожидается выбрасывание исключения, если не было передано 1, или 3 аргумента
            Assert.ThrowsException<ArgumentException>(() => service.CalculateFigureArea());
            Assert.ThrowsException<ArgumentException>(() => service.CalculateFigureArea(5, 5));
            Assert.ThrowsException<ArgumentException>(() => service.CalculateFigureArea(5, 5, 5, 5));
            Assert.ThrowsException<ArgumentException>(() => service.CalculateFigureArea(5, 5, 5, 5, 5));
        }

        /// <summary>
        /// Проверяет корректность метода, выполняющего вычисление площади круга по радиусу
        /// </summary>
        [TestMethod]
        public void CheckCorrectnessOfCircleAreaCalculation()
        {
            CalculationService service = new();

            double originalValue = new Random().NextDouble();

            // Выполнение private метода у service
            MethodInfo? method = service.GetType().GetTypeInfo().GetMethod(
                "CalculateAreaOfCircle", BindingFlags.NonPublic | BindingFlags.Instance);
            var calculatedResult = (double)method!.Invoke(service, new object[] { originalValue })!;

            double inverseFormulaCalculationResult = Math.Sqrt(calculatedResult / Math.PI);

            Assert.AreEqual(originalValue, inverseFormulaCalculationResult);
        }

        /// <summary>
        /// Проверяет корректность метода, выполняющего вычисление площади треугольника по длине сторон
        /// </summary>
        [TestMethod]
        public void CheckCorrectnessOfTriangleAreaCalculation()
        {
            CalculationService service = new();

            Random random = new();
            double firstSide = random.NextDouble(), secondSide = random.NextDouble(), thirdSide = random.NextDouble();

            // Выполнение private метода у service
            MethodInfo? method = service.GetType().GetTypeInfo().GetMethod(
                "CalculateAreaOfTriangle", BindingFlags.NonPublic | BindingFlags.Instance);
            var calculatedResult = (double)method!.Invoke(service,
                new object[] { firstSide, secondSide, thirdSide })!;

            // В качестве альтернативного вычисления используется альтернативная Формула Герона
            var alternateCalculatedResult = 0.25 * Sqrt(Pow(Pow(firstSide, 2) + Pow(secondSide, 2) + Pow(thirdSide, 2), 2)
                - (2 * (Pow(firstSide, 4) + Pow(secondSide, 4) + Pow(thirdSide, 4))));

            Assert.AreEqual(calculatedResult, alternateCalculatedResult);
        }

        /// <summary>
        /// Проверяет корректность метода, проверяющего треугольник на прямоугольность
        /// </summary>
        [TestMethod]
        public void CheckCorrectnessOfMethodSquarenessCheck()
        {
            CalculationService service = new();

            var rightTriangleSides = (a: 6, b: 10, c: 8);
            var nonRightTriangleSides = (a: 6, b: 10, c: 10);

            // Выполнение private метода у service
            MethodInfo? method = service.GetType().GetTypeInfo().GetMethod(
                "CheckSquarenessOfTriangle", BindingFlags.NonPublic | BindingFlags.Instance);
            var resultRightTriangleCheck = (bool)method!.Invoke(service,
                new object[] { rightTriangleSides.a, rightTriangleSides.b, rightTriangleSides.c })!;
            var resultNonRightTriangleCheck = (bool)method!.Invoke(service,
                new object[] { nonRightTriangleSides.a, nonRightTriangleSides.b, nonRightTriangleSides.c })!;

            Assert.IsTrue(resultRightTriangleCheck && !resultNonRightTriangleCheck);
        }
    }
}