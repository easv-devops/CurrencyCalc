namespace CurrencyCalc.Data;

public class History
{
    public DateTime Date { get; set; }
    public string Source { get; set; }
    public string Target { get; set; }
    public int Value { get; set; }
    public float Result { get; set; }
}