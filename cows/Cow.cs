//// hemmati
///tamrin damdari

///cow

public class Cow : Animal
{
    public Cow(int id, string name, bool ismale, double weight, DateTime birtday)
    {
       
        NumOfCows++;
        this.Weight = weight;
        this.ID = id;
        this.Name = name;
        this.isMale = ismale;
        this.BDate = birtday;
    }

    public override double TotalStressFactor(EnvironmentData Env)
    {
        double stressfactor = 0;

        stressfactor = stressfactor + Env.db.stressFactor() + Env.tds.stressFactor() + Env.ox.stressFactor()
        + Env.temp.stressFactor() + Env.aqi.stressFactor() + Env.density.stressFactor();

        return Math.Round(stressfactor / 6, 2);
    }

    public override int life()
    {
        double life = 0;

        foreach (EnvironmentData Env in Environments)
        {
            life = life + TotalStressFactor(Env);
        }
        return (int)Math.Floor(life);
    }

    public override int timeToDie()
    {
        return (maxlife * 365) - life();
    }

    public override double killPriority()
    {
        double killPriority = 0;

        int per = (maxlife * 365) - life();

        switch (per)
        {
            case >= 7300:
               return killPriority = 0;
                
            case int per1 when per1 < 7300 && per1 >= 5475:
             return   killPriority = 0.25;
                

            case int per1 when per1 < 5475 && per1 >= 3650:
             return   killPriority = 0.5;
                

            case int per1 when per1 < 3650 && per1 >= 1825:
             return   killPriority = 0.75;
                

            case int per1 when per1 < 1825 && per1 >= 0:
             return   killPriority = 1;     
        }
        return killPriority;
        
    }


    public override int costPerDay()
    {
        double costday = 0;
        foreach (Cost Cs in Costs)
        {
            costday = costday + (Cs.dailyUsage * Cs.price);
        }

        return (int)costday;
    }

    public override decimal IncomePerDay()
    {
        decimal income = 0;
        foreach (Product pro in Products)
        {
            if (pro.producedInUnitsPerDay == 0)
                income = income + (decimal)(pro.PricePerUnit * pro.producedToUnit);
            else
                income = income + (decimal)(pro.producedInUnitsPerDay * pro.PricePerUnit);
        }
        return income;
    }

    public override decimal IncomeMeal(double priceMeat) => (decimal)(Weight * priceMeat);


    public static int NumOfCows = 0;

    public static int maxlife { get; } = 25;

    List<CowParameter> CowParameter = new List<CowParameter>();

    public override string ToString()
    {
        return $"Name: {Name} BirthDate: {BDate} Age: {Math.Round((double)life() / 365, 0)} years old => Equivalent => {life()} days";
    }


    

}
