namespace NFLTeams.Models
{
    // used Model suffix to be less ambiguous when building out the seed data in the TeamContext
    public class DivisionModel
    {
        public string DivisionId { get; set; } = string.Empty;
        public string DivisionName { get; set; } = string.Empty;
    }
}
