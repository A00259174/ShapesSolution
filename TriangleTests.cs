// TriangleTests.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLibrary;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(12, result);
    }
}
