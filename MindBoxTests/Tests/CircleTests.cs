using MindBox.Figures;

namespace MindBoxTests.Tests;

/// <summary>
/// Предоставляет функционал для тестирования методов класса Circle.
/// </summary>
[TestFixture]
public class CircleTests
{
    /// <summary>
    /// Тестирование метода вычисления площади фигуры с отрицательным радиусом.
    /// Ожидается исключение типа ArgumentException.
    /// </summary>
    [Test]
    public void Circle_Initialization_NegativeRadius_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-3));
    }

    /// <summary>
    /// Тестирование метода вычисления площади фигуры с корректными данными.
    /// Ожидается совпадение с эталонным значением площади.
    /// </summary>
    [Test]
    public void Circle_GetArea_TriangleSides_CorrectArea()
    {
        Assert.That(new Circle(3).Area, Is.EqualTo(28.274333882308138));
    }
}
