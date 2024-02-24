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
                    new ConferenceModel { ConferenceID = "afc", ConferenceName = "AFC" },
                    new ConferenceModel { ConferenceID = "nfc", ConferenceName = "NFC" }
                );

            // divisions
            modelBuilder.Entity<DivisionModel>().HasData(
                    new DivisionModel { DivisionID = "north", DivisionName = "North" },
                    new DivisionModel { DivisionID = "south", DivisionName = "South" },
                    new DivisionModel { DivisionID = "east", DivisionName = "East" },
                    new DivisionModel { DivisionID = "west", DivisionName = "West" }
                );

            // teams  - new {} is an anonymous object since the Team object doesn't have a foreign key for Conference id or Division id 
            // those id's are provided in this new{} anonymous object as strings for conference (nfc, afc) and division (north, south, east, west))
            modelBuilder.Entity<TeamModel>().HasData(
                new { TeamId = "ari", TeamName = "Arizona Cardinals", ConferenceID = "nfc", DivisionID = "west", LogoImage = "ARI.png" },
                new { TeamID = "atl", TeamName = "Atlanta Falcons", ConferenceID = "nfc", DivisionID = "south", LogoImage = "ATL.png" },
                new { TeamID = "bal", TeamName = "Baltimore Ravens", ConferenceID = "afc", DivisionID = "north", LogoImage = "BAL.png" },
                new { TeamID = "buf", TeamName = "Buffalo Bills", ConferenceID = "afc", DivisionID = "east", LogoImage = "BUF.png" },
                new { TeamID = "car", TeamName = "Carolina Panthers", ConferenceID = "nfc", DivisionID = "south", LogoImage = "CAR.png" },
                new { TeamID = "chi", TeamName = "Chicago Bears", ConferenceID = "nfc", DivisionID = "north", LogoImage = "CHI.png" },
                new { TeamID = "cin", TeamName = "Cincinnati Bengals", ConferenceID = "afc", DivisionID = "north", LogoImage = "CIN.png" },
                new { TeamID = "cle", TeamName = "Cleveland Browns", ConferenceID = "afc", DivisionID = "north", LogoImage = "CLE.png" },
                new { TeamID = "dal", TeamName = "Dallas Cowboys", ConferenceID = "nfc", DivisionID = "east", LogoImage = "DAL.png" },
                new { TeamID = "den", TeamName = "Denver Broncos", ConferenceID = "afc", DivisionID = "west", LogoImage = "DEN.png" },
                new { TeamID = "det", TeamName = "Detroit Lions", ConferenceID = "nfc", DivisionID = "north", LogoImage = "DET.png" },
                new { TeamID = "gb", TeamName = "Green Bay Packers", ConferenceID = "nfc", DivisionID = "north", LogoImage = "GB.png" },
                new { TeamID = "hou", TeamName = "Houston Texans", ConferenceID = "afc", DivisionID = "south", LogoImage = "HOU.png" },
                new { TeamID = "ind", TeamName = "Indianapolis Colts", ConferenceID = "afc", DivisionID = "south", LogoImage = "IND.png" },
                new { TeamID = "jax", TeamName = "Jacksonville Jaguars", ConferenceID = "afc", DivisionID = "south", LogoImage = "JAX.png" },
                new { TeamID = "kc", TeamName = "Kansas City Chiefs", ConferenceID = "afc", DivisionID = "west", LogoImage = "KC.png" },
                new { TeamID = "lv", TeamName = "Las Vegas Raiders", ConferenceID = "afc", DivisionID = "west", LogoImage = "LV.png" },
                new { TeamID = "lac", TeamName = "Los Angeles Chargers", ConferenceID = "afc", DivisionID = "west", LogoImage = "LAC.png" },
                new { TeamID = "lar", TeamName = "Los Angeles Rams", ConferenceID = "nfc", DivisionID = "west", LogoImage = "LAR.png" },
                new { TeamID = "mia", TeamName = "Miami Dolphins", ConferenceID = "afc", DivisionID = "east", LogoImage = "MIA.png" },
                new { TeamID = "min", TeamName = "Minnesota Vikings", ConferenceID = "nfc", DivisionID = "north", LogoImage = "MIN.png" },
                new { TeamID = "ne", TeamName = "New England Patriots", ConferenceID = "afc", DivisionID = "east", LogoImage = "NE.png" },
                new { TeamID = "no", TeamName = "New Orleans Saints", ConferenceID = "nfc", DivisionID = "south", LogoImage = "NO.png" },
                new { TeamID = "nyg", TeamName = "New York Giants", ConferenceID = "nfc", DivisionID = "east", LogoImage = "NYG.png" },
                new { TeamID = "nyj", TeamName = "New York Jets", ConferenceID = "afc", DivisionID = "east", LogoImage = "NYJ.png" },
                new { TeamID = "phi", TeamName = "Philadelphia Eagles", ConferenceID = "nfc", DivisionID = "east", LogoImage = "PHI.png" },
                new { TeamID = "pit", TeamName = "Pittsburgh Steelers", ConferenceID = "afc", DivisionID = "north", LogoImage = "PIT.png" },
                new { TeamID = "sf", TeamName = "San Francisco 49ers", ConferenceID = "nfc", DivisionID = "west", LogoImage = "SF.png" },
                new { TeamID = "sea", TeamName = "Seattle Seahawks", ConferenceID = "nfc", DivisionID = "west", LogoImage = "SEA.png" },
                new { TeamID = "tb", TeamName = "Tampa Bay Buccaneers", ConferenceID = "nfc", DivisionID = "south", LogoImage = "TB.png" },
                new { TeamID = "ten", TeamName = "Tennessee Titans", ConferenceID = "afc", DivisionID = "south", LogoImage = "TEN.png" },
                new { TeamID = "was", TeamName = "Washington Commanders", ConferenceID = "nfc", DivisionID = "east", LogoImage = "WAS.png" }
                );
        }
    }
}
