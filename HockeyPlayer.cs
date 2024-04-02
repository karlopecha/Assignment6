namespace Assignment6
{
    public class HockeyPlayer : IComparable<HockeyPlayer>
    {
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
            return other == null ? 1 : Name.CompareTo(other.Name);
        }
    }
}
