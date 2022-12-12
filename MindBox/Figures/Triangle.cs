using MindBox.Base;

namespace MindBox.Figures
{
    /// <summary>
    /// Представляет методы для вычисления площади треугольника.
    /// </summary>
    public class Triangle : Shape
    {
        private readonly List<double> _sides;
        private readonly bool _isRight;

        /// <summary>
        /// true - если треугольник прямоугольный.
        /// </summary>
        public bool IsRight => _isRight;

        /// <summary>
        /// Инициализирует новый экземпляр класса Triangle.
        /// </summary>
        /// <param name="sideA"> Сторона треугольника A.</param>
        /// <param name="sideB"> Сторона треугольника B.</param>
        /// <param name="sideC"> Сторона треугольника C.</param>
        public Triangle(double sideA, double sideB, double sideC)
            : base(CalculateArea(sideA, sideB, sideC))
        {
            ValidateData(sideA, sideB, sideC);
            _sides = new List<double>() { sideA, sideB, sideC };
            _sides.Sort();
            _isRight = CheckIsRight();
        }

        #region Private methods

        /// <summary>
        /// Вычисляет площадь треугольника любого типа.
        /// </summary>
        /// <param name="sideA"> Сторона треугольника A.</param>
        /// <param name="sideB"> Сторона треугольника B.</param>
        /// <param name="sideC"> Сторона треугольника C.</param>
        /// <returns> Площадь треугольника.</returns>
        private static double CalculateArea(double sideA, double sideB, double sideC)
        {
            var perimeter = (sideA + sideB + sideC) / 2;

            return Math.Sqrt(perimeter
                * (perimeter - sideA)
                * (perimeter - sideB)
                * (perimeter - sideC));
        }

        /// <summary>
        /// Проверяет, могут ли данные стороны образовать треугольник.
        /// </summary>
        /// <param name="sideA"> Сторона треугольника A.</param>
        /// <param name="sideB"> Сторона треугольника B.</param>
        /// <param name="sideC"> Сторона треугольника C.</param>
        private static void ValidateData(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны фигуры не могут быть меньше или равны нулю.");
            }

            if (!(sideA <= sideB + sideC || sideB <= sideA + sideC || sideC <= sideA + sideB))
            {
                throw new ArgumentException("Треугольник с данными сторонами не существует.");
            }
        }

        /// <summary>
        /// Проверяет треугольник на наличие прямого угла.
        /// </summary>
        /// <returns> true - если треугольник прямоугольный.</returns>
        private bool CheckIsRight()
        {
            return _sides[0] == Math.Sqrt(Math.Pow(_sides[1], 2) + Math.Pow(_sides[2], 2))
                || _sides[1] == Math.Sqrt(Math.Pow(_sides[0], 2) + Math.Pow(_sides[2], 2))
                || _sides[2] == Math.Sqrt(Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2));
        }

        #endregion
    }
}
