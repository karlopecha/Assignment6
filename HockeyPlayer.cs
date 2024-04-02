namespace Assignment6
{
    public class HockeyPlayer
    {
        public HockeyPlayer(string n, string j)
        {
            Name = n;
            JerseyNumber = j;
        }

        public readonly string Name;
        public string JerseyNumber { get; }
        public string GoalsScored { get; set; }
    }
}
