namespace TestTask.FigureCalculator.Tests;

public class CircleTests
{
    [Fact]
    public void Validate_TriangleInputData_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
        Assert.Throws<ArgumentException>(() => new Circle(3, -1));
        Assert.Throws<ArgumentException>(() => new Circle(3, 16));
    }
    
    [Fact]
    public void Get_Area_ReturnsAreaWithZeroSymbolAfterComma()
    {
        var circle = new Circle(2);

        var actual = circle.GetArea();
        
        Assert.Equal(13, actual);
    }
    
    [Fact]
    public void Get_Area_ReturnsAreaWithOneSymbolAfterComma()
    {
        var circle = new Circle(2, 1);

        var actual = circle.GetArea();
        
            Assert.Equal(12.6, actual);
    }
    
    [Fact]
    public void Get_Area_ReturnsAreaWithFifteenSymbolAfterComma()
    {
        var circle = new Circle(2, 15);

        var actual = circle.GetArea();
        
        Assert.Equal(12.566370614359172, actual);
    }
}