using Microsoft.EntityFrameworkCore;

namespace NFLTeams.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) 
            : base(options) { }

        // used Model suffix to be less ambiguous when building out the seed data here in the TeamContext
        // three tables based on the three models ConferenceModel, DivisionModel, TeamModel each needs a DbSet
        public DbSet<ConferenceModel> Conferences { get; set; } = null!;
        public DbSet<DivisionModel> Divisions { get; set; } = null!;
        public DbSet<TeamModel> Teams { get; set; } = null!;

        // seed the db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            // conferences
            modelBuilder.Entity<ConferenceModel>().HasData(
                    new ConferenceModel { ConferenceId = "afc", ConferenceName = "AFC" },
                    new ConferenceModel { ConferenceId = "nfc", ConferenceName = "NFC" }
                );

            // divisions
            modelBuilder.Entity<DivisionModel>().HasData(
                    new DivisionModel { DivisionId = "north", DivisionName = "North" },
                    new DivisionModel { DivisionId = "south", DivisionName = "South" },
                    new DivisionModel { DivisionId = "east", DivisionName = "East" },
                    new DivisionModel { DivisionId = "west", DivisionName = "West" }
                );

            // teams  - new {} is an anonymous object since the Team object doesn't have a foreign key for Conference id or Division id 
            // those id's are provided in this new{} anonymous object as strings for conference (nfc, afc) and division (north, south, east, west))
            modelBuilder.Entity<TeamModel>().HasData(
                new { TeamId = "ari", TeamName = "Arizona Cardinals", ConferenceId = "nfc", DivisionId = "west", LogoImage = "ARI.png" },
                new { TeamID = "atl", TeamName = "Atlanta Falcons", ConferenceId = "nfc", DivisionId = "south", LogoImage = "ATL.png" },
                new { TeamID = "bal", TeamName = "Baltimore Ravens", ConferenceId = "afc", DivisionId = "north", LogoImage = "BAL.png" },
                new { TeamID = "buf", TeamName = "Buffalo Bills", ConferenceId = "afc", DivisionId = "east", LogoImage = "BUF.png" },
                new { TeamID = "car", TeamName = "Carolina Panthers", ConferenceId = "nfc", DivisionId = "south", LogoImage = "CAR.png" },
                new { TeamID = "chi", TeamName = "Chicago Bears", ConferenceId = "nfc", DivisionId = "north", LogoImage = "CHI.png" },
                new { TeamID = "cin", TeamName = "Cincinnati Bengals", ConferenceId = "afc", DivisionId = "north", LogoImage = "CIN.png" },
                new { TeamID = "cle", TeamName = "Cleveland Browns", ConferenceId = "afc", DivisionId = "north", LogoImage = "CLE.png" },
                new { TeamID = "dal", TeamName = "Dallas Cowboys", ConferenceId = "nfc", DivisionId = "east", LogoImage = "DAL.png" },
                new { TeamID = "den", TeamName = "Denver Broncos", ConferenceId = "afc", DivisionId = "west", LogoImage = "DEN.png" },
                new { TeamID = "det", TeamName = "Detroit Lions", ConferenceId = "nfc", DivisionId = "north", LogoImage = "DET.png" },
                new { TeamID = "gb", TeamName = "Green Bay Packers", ConferenceId = "nfc", DivisionId = "north", LogoImage = "GB.png" },
                new { TeamID = "hou", TeamName = "Houston Texans", ConferenceId = "afc", DivisionId = "south", LogoImage = "HOU.png" },
                new { TeamID = "ind", TeamName = "Indianapolis Colts", ConferenceId = "afc", DivisionId = "south", LogoImage = "IND.png" },
                new { TeamID = "jax", TeamName = "Jacksonville Jaguars", ConferenceId = "afc", DivisionId = "south", LogoImage = "JAX.png" },
                new { TeamID = "kc", TeamName = "Kansas City Chiefs", ConferenceId = "afc", DivisionId = "west", LogoImage = "KC.png" },
                new { TeamID = "lv", TeamName = "Las Vegas Raiders", ConferenceId = "afc", DivisionId = "west", LogoImage = "LV.png" },
                new { TeamID = "lac", TeamName = "Los Angeles Chargers", ConferenceId = "afc", DivisionId = "west", LogoImage = "LAC.png" },
                new { TeamID = "lar", TeamName = "Los Angeles Rams", ConferenceId = "nfc", DivisionId = "west", LogoImage = "LAR.png" },
                new { TeamID = "mia", TeamName = "Miami Dolphins", ConferenceId = "afc", DivisionId = "east", LogoImage = "MIA.png" },
                new { TeamID = "min", TeamName = "Minnesota Vikings", ConferenceId = "nfc", DivisionId = "north", LogoImage = "MIN.png" },
                new { TeamID = "ne", TeamName = "New England Patriots", ConferenceId = "afc", DivisionId = "east", LogoImage = "NE.png" },
                new { TeamID = "no", TeamName = "New Orleans Saints", ConferenceId = "nfc", DivisionId = "south", LogoImage = "NO.png" },
                new { TeamID = "nyg", TeamName = "New York Giants", ConferenceId = "nfc", DivisionId = "east", LogoImage = "NYG.png" },
                new { TeamID = "nyj", TeamName = "New York Jets", ConferenceId = "afc", DivisionId = "east", LogoImage = "NYJ.png" },
                new { TeamID = "phi", TeamName = "Philadelphia Eagles", ConferenceId = "nfc", DivisionId = "east", LogoImage = "PHI.png" },
                new { TeamID = "pit", TeamName = "Pittsburgh Steelers", ConferenceId = "afc", DivisionId = "north", LogoImage = "PIT.png" },
                new { TeamID = "sf", TeamName = "San Francisco 49ers", ConferenceId = "nfc", DivisionId = "west", LogoImage = "SF.png" },
                new { TeamID = "sea", TeamName = "Seattle Seahawks", ConferenceId = "nfc", DivisionId = "west", LogoImage = "SEA.png" },
                new { TeamID = "tb", TeamName = "Tampa Bay Buccaneers", ConferenceId = "nfc", DivisionId = "south", LogoImage = "TB.png" },
                new { TeamID = "ten", TeamName = "Tennessee Titans", ConferenceId = "afc", DivisionId = "south", LogoImage = "TEN.png" },
                new { TeamID = "was", TeamName = "Washington Commanders", ConferenceId = "nfc", DivisionId = "east", LogoImage = "WAS.png" }
                );
        }
    }
}
