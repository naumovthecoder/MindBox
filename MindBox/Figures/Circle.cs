using MindBox.Base;

namespace MindBox.Figures
{
    /// <summary>
    /// Представляет методы для вычисления площади круга.
    /// </summary>
	public class Circle : Shape
	{
        /// <summary>
        /// Инициализирует новый экземпляр класса Circle.
        /// </summary>
        /// <param name="radius"> Радиус круга.</param>
        public Circle(double radius) : base(Math.PI * Math.Pow(radius, 2))
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус фигуры не может быть меньше или равен нулю.");
            }
        }
    }
}

