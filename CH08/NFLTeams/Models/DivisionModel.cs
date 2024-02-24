namespace NFLTeams.Models
{
    // used Model suffix to be less ambiguous when building out the seed data in the TeamContext
    public class DivisionModel
    {
        public string DivisionID { get; set; } = string.Empty;

        // Name suffix so that its less ambiguous when building out the seed data in the TeamContext
        public string DivisionName { get; set; } = string.Empty;
    }
}
