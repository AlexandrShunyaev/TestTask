using TestTask.FigureCalculator.Common.Interfaces;

namespace TestTask.FigureCalculator.Figures;

public abstract class AbstractFigure: IFigure
{
    public int SymbolsAfterComma { get; set; }

    protected AbstractFigure(int symbolsAfterComma)
    {
        ValidateSymbolsAfterComma(symbolsAfterComma);
        
        SymbolsAfterComma = symbolsAfterComma;
    }
    
    #region PublicMethods
    
    public abstract double GetArea();
    
    #endregion

    #region PrivateMethods

    private void ValidateSymbolsAfterComma(int symbolsAfterComma)
    {
        if (symbolsAfterComma is < 0 or > 15)
            throw new ArgumentException(
                "Amount of symbols after comma should be from 0 to 15 ",
                nameof(symbolsAfterComma)
            );
    }

    #endregion

}