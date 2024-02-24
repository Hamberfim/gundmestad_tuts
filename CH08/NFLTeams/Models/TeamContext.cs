using Microsoft.EntityFrameworkCore;

namespace NFLTeams.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }

        // used Model suffix to be less ambiguous when building out the seed data here in the TeamContext
        // three tables based on the three models ConferenceModel, DivisionModel, TeamModel each needs a DbSet
        public DbSet<ConferenceModel> Conferences { get; set; } = null!;
        public DbSet<DivisionModel> Divisions { get; set; } = null!;
        public DbSet<TeamModel> Teams { get; set; } = null!;

        // seed the db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // conferences
            modelBuilder.Entity<ConferenceModel>().HasData(
                    new ConferenceModel { ConferenceId = "afc", ConferenceName = "AFC"},
                    new ConferenceModel { ConferenceId = "nfc", ConferenceName = "NFC"}
                );

            // divisions
            modelBuilder.Entity<DivisionModel>().HasData();

            // teams
            modelBuilder.Entity<TeamModel>().HasData();

        }
    }
}
