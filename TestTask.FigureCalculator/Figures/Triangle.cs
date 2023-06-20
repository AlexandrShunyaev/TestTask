namespace TestTask.FigureCalculator.Figures;

public sealed class Triangle: AbstractFigure
{
    #region FieldsAndCtor

    /// <summary>
    /// First side of triangle
    /// </summary>
    public double SideA { get; }
    
    /// <summary>
    /// Second side of triangle
    /// </summary>
    public double SideB { get; }
    
    /// <summary>
    /// Third side of triangle
    /// </summary>
    public double SideC { get; }
    
    /// <summary>
    /// Indicates whether a triangle is a right triangle
    /// </summary>
    public bool IsRightTriangle { get; }
    
    private readonly double _perimeter;

    /// <summary>
    /// Constructor of class Triangle 
    /// </summary>
    /// <param name="sideA">first side of triangle</param>
    /// <param name="sideB">second side of triangle</param>
    /// <param name="sideC">third side of triangle</param>
    /// <param name="symbolsAfterComma"></param>
    /// <exception cref="ArgumentException">
    /// Throw when side less than minimum of double. Also throw when greatest side greater then sum of other sides
    /// </exception>
    public Triangle(double sideA, double sideB, double sideC, int symbolsAfterComma = 0) : base(symbolsAfterComma)
    {
        ValidateSidesLength(sideA, sideB, sideC);

        double maxSide = sideA, b = sideB, c = sideC;
        if (b - maxSide > double.Epsilon) (maxSide, b) = (b, maxSide);
        if (c - maxSide > double.Epsilon) (maxSide, c) = (c, maxSide);
        
        _perimeter = sideA + sideB + sideC;
        
        ValidateGreatestSide(maxSide);
        
        IsRightTriangle = Math.Abs(Math.Pow(maxSide, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < double.Epsilon;

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    #endregion
    
    #region PublicMethods
    
    public override double GetArea()
    {
        var semiPerimeter = _perimeter / 2;
        return Math.Round(
            Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC)),
            SymbolsAfterComma
        );
    }
    
    #endregion

    #region PrivateMethods

    private void ValidateSidesLength(double sideA, double sideB, double sideC)
    {
        if (sideA < double.Epsilon)
            throw new ArgumentException($"Side 'A' should be greater than {double.Epsilon}", nameof(sideA));

        if (sideB < double.Epsilon)
            throw new ArgumentException($"Side 'B' should be greater than {double.Epsilon}", nameof(sideB));

        if (sideC < double.Epsilon)
            throw new ArgumentException($"Side 'C' should be greater than {double.Epsilon}", nameof(sideC));
    }

    private void ValidateGreatestSide(double maxSide)
    {
        if (_perimeter - 2 * maxSide < double.Epsilon)
            throw new ArgumentException("Greatest side should be less than sum of two other sides");
    }

    #endregion
}