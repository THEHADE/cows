//// hemmati
///tamrin damdari

public abstract class Animal
{
    static Animal()
    {
        NumOfAnimals = 0;

    }

    public Animal()
    {
        NumOfAnimals++;
        Number = NumOfAnimals;
    }
    public static int NumOfAnimals { get; private set; }

    public int Number { get; private set; }
    public int ID { get; init; }

    public string Name { get; init; }

    public bool isMale { get; init; }

    public double Weight { get; init; }

    public DateTime BDate { get; init; }

    public List<Product> Products { get; set; }

    public List<EnvironmentData> Environments { get; set; }

    public List<Cost> Costs { get; set; }

    public abstract double TotalStressFactor(EnvironmentData Env);

    public abstract int life();

    public abstract int timeToDie();

    public abstract double killPriority();

    public abstract int costPerDay();

    public abstract decimal IncomePerDay();

    public abstract decimal IncomeMeal(double priceMeat);


    public override string ToString()
    {
        return $"Id: {ID} Name: {Name} IsMale: {isMale} Weight: {Weight}Gr  Birth Date: {BDate} Number Of Animals: {NumOfAnimals}";
    }
}
