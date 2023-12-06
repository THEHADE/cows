//hemmati 
//gavdari







class Animal
{
    public string nam;
    public bool gender;
    public float weight;
    public DateTime birthDate { get; init; }

    List<Environment> Environment = new List<Environment>();

    public virtual float srsFactor()
    {

    }

    public int life()
    {

    }

    public int tmToDie()
    {

    }

    public float killPri()
    {

    }

    public int coPerDay()
    {

    }

    public int valPerDay()
    {

    }

}
class SheepParameter
{
    public int timeToStand;
    public int timeToDeal;
    public int timeToRelax;
    public int numberOfMilkProduct;
    public DateTime date;
}


class healthParameter
{
    public string name;
    public int current;
    public int standart;

    public override float stressFactor()
    {

    }
}

class cow : Animal
{
    public DateTime birthDate { get; init; }
    public static readonly int maxlife { get; set; }

    List<Environment> Environment = new List<Environment>();
    List<CowParameter> CowParameter = new List<CowParameter>();
    public static int number;
}

class sheep : Animal
{
    public DateTime birthDate { get; init; }
    public static readonly int maxlife { get; set; }

    List<Environment> Environment = new List<Environment>();
    List<SheepParameter> CowParameter = new List<SheepParameter>();
    public static int number;
}
class CowParameter
{
    public int timeToStand;
    public int timeToDeal;
    public int timeToRelax;
    public int numberOfMilkProduct;
    public DateTime date;
}



class Environment
{
    public double temp;
    public double tds;
    public double density;
    public double db;
    public double aqi;
    public double ox;

    public DateTime date;
}
