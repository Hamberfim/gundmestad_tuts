namespace NFLTeams.Models
{
    // used Model suffix to be less ambiguous when building out the seed data in the TeamContext
    public class TeamModel
    {
        public string TeamID { get; set; } = string.Empty;

        // Name suffix so that its less ambiguous when building out the seed data in the TeamContext
        public string TeamName { get; set; } = string.Empty;
        public ConferenceModel Conference { get; set; } = null!;

        public DivisionModel Division { get; set; } = null!;

        public string LogoImage { get; set; } = string.Empty;
    }
}
