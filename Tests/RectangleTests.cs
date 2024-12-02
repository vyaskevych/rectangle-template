using Xunit;
using RectangleApp;

public class RectangleTests
{
    [Fact]
    public void AreaCalculation_IsCorrect()
    {
        var rectangle = new Rectangle { Width = 5, Height = 10 };
        Assert.Equal(50, rectangle.CalculateArea());
    }
}
