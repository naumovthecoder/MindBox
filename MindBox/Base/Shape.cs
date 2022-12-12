namespace MindBox.Base
{
    public abstract class Shape
    {
        private readonly double _area;

        /// <summary>
        /// Получает площадь фигуры.
        /// </summary>
        public double Area => _area;

        protected Shape(double area)
        {
            _area = area;
        }

        /// <summary>
        /// Преобразует данные фигуры в её эквивалентное строковое представление.
        /// </summary>
        /// <returns> Строковое представление данных этой фигуры.</returns>
        public override string ToString()
        {
            return $"Тип фигуры: {GetType().Name}, S = {_area:F2}";
        }
    }
}
