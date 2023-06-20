
namespace TestTask.FigureCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void Validate_TriangleInputData_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 0, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 0));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 5, -1));
        Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 5, 16));
    }
    
    [Fact]
    public void Get_Area_ReturnsAreaWithZeroSymbolsAfterComma()
    {
        var triangle = new Triangle(4, 4, 5);

        var actual = triangle.GetArea();
        
        Assert.Equal(8, actual);
    }
    
    [Fact]
    public void Get_Area_ReturnsAreaWithOneSymbolsAfterComma()
    {
        var triangle = new Triangle(4, 4, 5, 1);

        var actual = triangle.GetArea();
        
        Assert.Equal(7.8, actual);
    }
    
    [Fact]
    public void Get_Area_ReturnsAreaWithFifteenSymbolsAfterComma()
    {
        var triangle = new Triangle(4, 4, 5, 15);

        var actual = triangle.GetArea();
        
        Assert.Equal(7.806247497997997, actual);
    }
    
    [Fact]
    public void Check_TriangleIsRightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        var actual = triangle.IsRightTriangle;
        
        Assert.True(actual);
    }
    
    [Fact]
    public void Check_TriangleIsRightTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(4, 4, 5);

        var actual = triangle.IsRightTriangle;
        
        Assert.False(actual);
    }
}