namespace TestTask.FigureCalculator.Figures;

public sealed class Circle : AbstractFigure
{
    #region FieldsAndCtor
    
    public double Radius { get; }

    /// <summary>
    /// Constructor of class Circle 
    /// </summary>
    /// <param name="radius">Radius of circle</param>
    /// <param name="symbolsAfterComma"></param>
    /// <exception cref="ArgumentException">Throw when radius less than minimum of double</exception>
    public Circle(double radius, int symbolsAfterComma = 0) : base(symbolsAfterComma)
    {
        ValidateInputData(radius, symbolsAfterComma);
        
        Radius = radius;
        SymbolsAfterComma = symbolsAfterComma;
    }
    
    #endregion

    #region PublicMethods
    
    public override double GetArea() => Math.Round(Math.PI * Math.Pow(Radius, 2), SymbolsAfterComma);

    #endregion

    #region PrivateMethods

    private void ValidateInputData(double radius, int symbolsAfterComma)
    {
        if (radius < double.Epsilon)
            throw new ArgumentException($"Radius should be greater than {double.Epsilon}", nameof(radius));
    }

    #endregion
}