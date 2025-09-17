namespace M426;

public class TaxRange
{
    public TaxRange()
    {
    }
    
    public TaxRange(int min, int max, double tax)
    {
        this.min = min;
        this.max = max;
        this.tax = tax;
    }

    public int min { get; set; }
    public int max { get; set; }
    public double tax { get; set; }
}