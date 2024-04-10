namespace Assignment6
{
    [Serializable]
    public class HockeyPlayer : IComparable<HockeyPlayer>
    {
        public static string SortBy { get; set; }
        public static bool IsDesc { get; set; }

        public HockeyPlayer(string n, string j)
        {
            Name = n;

            int.TryParse(j, out int jInt);
            JerseyNumber = jInt;
        }

        public readonly string Name;
        public int JerseyNumber { get; }
        public int GoalsScored { get; set; }

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

        public override string ToString()
        {
            return $"{Name,-40}{JerseyNumber,8}{GoalsScored,6}";
        }
    }
}
