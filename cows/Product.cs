//// hemmati
///tamrin damdari



///cow

///PRODUCT
public class Product
{
    public Product(string name, string unitOfMeasure, int producedInUnitsPerDay, int NoProduct, int producedToUnit, int PricePerUnit)
    {
        NoProduct++;

        this.nameOF = name;
        this.MeasureType = unitOfMeasure;
        this.producedInUnitsPerDay = producedInUnitsPerDay;
        this.NUMProduct = NoProduct;
        this.producedToUnit = producedToUnit;
        this.PricePerUnit = PricePerUnit;
    }
    public int NUMProduct { get; private set; } = 0;
    public string nameOF { get; private set; }
    public string MeasureType { get; private set; }
    public double producedInUnitsPerDay { get; private set; }
    public double producedToUnit { get; private set; }
    public double PricePerUnit { get; private set; }



    public override string ToString()
    {
        return $"Number Of Product: {NUMProduct} Name: {nameOF} Price per unit: {PricePerUnit}T  Produced in units per day: {producedInUnitsPerDay}{MeasureType} Produced to unit: {producedToUnit}{MeasureType}";
    }
}
