//// hemmati
///tamrin damdari



///cow

//cost
public class Cost
{
    public string name { get; set; }
    public string unitOfMeasure { get; set; }
    public double dailyUsage { get; set; }
    public double price { get; set; }

    public override string ToString()
    {
        return $"Name: {name}  Daily usage: {dailyUsage}{unitOfMeasure} Price: {price}T";
    }
}