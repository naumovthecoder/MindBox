using MindBox.Figures;

namespace MindBoxTests.Tests;

/// <summary>
/// Предоставляет функционал для тестирования методов класса Triangle.
/// </summary>
[TestFixture]
public class TriangleTests
{
    /// <summary>
    /// Тестирование метода проверки наличия прямого угла с корректными данными.
    /// Ожидается положительный исход.
    /// </summary>
    [Test]
    public void Triangle_IsRight_CorrectSides_True()
    {
        Assert.That(new Triangle(3, 4, 5).IsRight, Is.EqualTo(true));
    }

    /// <summary>
    /// Тестирование метода проверки наличия прямого угла с некорректными данными.
    /// Ожидается отрицательный исход.
    /// </summary>
    [Test]
    public void Triangle_IsRight_IncorrectSides_False()
    {
        Assert.That(new Triangle(2, 5, 4).IsRight, Is.EqualTo(false));
    }

    /// <summary>
    /// Тестирование метода вычисления площади фигуры с корректными данными.
    /// Ожидается совпадение с эталонным значением площади.
    /// </summary>
    [Test]
    public void Triangle_Area_CorrectSides_CorrectArrea()
    {
        Assert.That(new Triangle(3, 4, 5).Area, Is.EqualTo(6));
    }

    /// <summary>
    /// Тестирование метода вычисления площади фигуры с некорректными данными.
    /// Ожидается исключение типа ArgumentException.
    /// </summary>
    [Test]
    public void Triangle_Area_IncorrectSides_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
    }
}
