namespace NFLTeams.Models
{
    // used Model suffix to be less ambiguous when building out the seed data in the TeamContext
    public class Team
    {
        public string TeamID { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public Conference Conference { get; set; } = null!;

        public Division Division { get; set; } = null!;

        public string LogoImage { get; set; } = string.Empty;
    }
}
