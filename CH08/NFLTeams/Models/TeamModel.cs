namespace NFLTeams.Models
{
    public class TeamModel
    {
        public string TeamId { get; set; } = string.Empty; 
        public string TeamName { get; set; } = string.Empty;
        public ConferenceModel Conference { get; set; } = null!;

        public DivisionModel Division { get; set; } = null!;

        public string LogoImage { get; set; } = string.Empty;
    }
}
