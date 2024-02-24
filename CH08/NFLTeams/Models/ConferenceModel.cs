namespace NFLTeams.Models
{
    // used Model suffix to be less ambiguous when building out the seed data in the TeamContext
    public class ConferenceModel
    {
        public string ConferenceId { get; set; } = string.Empty;
        public string ConferenceName { get; set; } = string.Empty;

    }
}
