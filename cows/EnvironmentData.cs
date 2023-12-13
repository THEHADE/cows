//// hemmati
///tamrin damdari



///cow

///ENVData
public class EnvironmentData
{
    public HealthParameter<double> temp { get; set; }
    public HealthParameter<double> tds { get; set; }
    public HealthParameter<double> density { get; set; }
    public HealthParameter<double> db { get; set; }
    public HealthParameter<double> aqi { get; set; }
    public HealthParameter<double> ox { get; set; }

    public DateTime date { get; set; }

    public override string ToString()
    {
        return $"Temp: {temp} Tds: {tds} Density: {density} Db: {db} Aqi: {aqi} Ox: {ox} Date Time: {date}";
    }
}
