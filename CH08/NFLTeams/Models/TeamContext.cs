using Microsoft.EntityFrameworkCore;

namespace NFLTeams.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }

        // three tables based on the three models Conference, Division, Team each needs a DbSet
        public DbSet<ConferenceModel> Conferences { get; set; } = null!;
        public DbSet<DivisionModel> Divisions { get; set; } = null!;
        public DbSet<TeamModel> Teams { get; set; } = null!;

        // seed the db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // conferences
            modelBuilder.Entity<ConferenceModel>().HasData();

            // divisions
            modelBuilder.Entity<DivisionModel>().HasData();

            // teams
            modelBuilder.Entity<TeamModel>().HasData();

        }
    }
}
