//// hemmati
///tamrin damdari



///cow

//COW parameter
public class CowParameter
    {
        public int timeToStand { get; set; }
        public int timeToDeal { get; set; }
        public int timeToRelax { get; set; }

        public DateTime date { get; set; }

        public override string ToString()
        {
            return $"TimeToStand: {timeToStand} TimeToDeal: {timeToDeal} TimeToRelax: {timeToRelax} DateTime: {date}";
        }
    }
