namespace Assignment6
{
    public class HockeyPlayer : IComparable<HockeyPlayer>
    {
        public static string SortBy { get; set; }

        public HockeyPlayer(string n, string j)
        {
            Name = n;
            JerseyNumber = j;
        }

        public readonly string Name;
        public string JerseyNumber { get; }
        public string GoalsScored { get; set; }

        public int CompareTo(HockeyPlayer? other)
        {
            if (other == null) return 1;
            switch (SortBy)
            {
                case "J":
                    return JerseyNumber.CompareTo(other.JerseyNumber);
                case "G":
                    return GoalsScored.CompareTo(other.GoalsScored);
                default:
                    return Name.CompareTo(other.Name);
            }
        }
    }
}
