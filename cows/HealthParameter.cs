//// hemmati
///tamrin damdari



///cow

///HLT Parameter
public class HealthParameter<T>
{
    public string name { get; set; }
    public T current { get; set; }
    public T standard { get; set; }

    public int alpha { get; set; }

    public double stressFactor()
    {
        double x = (Convert.ToDouble(current) / Convert.ToDouble(standard)) * alpha;
        return Math.Round(x, 2);
    }

    public override string ToString() => $"Name: {name} Standard: {standard} Current: {current}";
}
