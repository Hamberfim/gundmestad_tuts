namespace NFLTeams.Models
{
    // used Model suffix to be less ambiguous when building out the seed data in the TeamContext
    public class TeamModel
    {
        public string TeamId { get; set; } = string.Empty; 
        public string TeamName { get; set; } = string.Empty;
        public ConferenceModel Conference { get; set; } = null!;

        public DivisionModel Division { get; set; } = null!;

        public string LogoImage { get; set; } = string.Empty;
    }
}
