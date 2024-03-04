namespace NFLTeams.Models
{
    public class MySession
    {
        private const string TeamsKey = "teams";
        private ISession Session { get; set; }

        // constructor 
        public MySession(ISession session) => Session = session;

        // using SessionExtentions class
        public List<Team> GetTeams() => Session.GetObject<List<Team>>(TeamsKey) ?? new List<Team>();

        public void SetTeams(List<Team> teams) => Session.SetObject(TeamsKey, teams);
    }
}
