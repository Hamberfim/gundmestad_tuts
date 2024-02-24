namespace NFLTeams.Models
{
    // used Model suffix to be less ambiguous when building out the seed data in the TeamContext
    public class ConferenceModel
    {
        public string ConferenceID { get; set; } = string.Empty;

        // Name suffix so that its less ambiguous when building out the seed data in the TeamContext
        public string ConferenceName { get; set; } = string.Empty;

    }
}
