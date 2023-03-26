using DataLayer.Entities;

namespace DataLayer
{
    
    public static class DbContext
    {
        static void Main() { }
        public static List<Team> Teams = new List<Team>
        {
            new Team
            {
                Id = 1,
                Name = "Team 1",
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        FirstName = "Player 1",
                        LastName = "Player 1",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 2,
                        FirstName = "Player 2",
                        LastName = "Player 2",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 3,
                        FirstName = "Player 3",
                        LastName = "Player 3",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 4,
                        FirstName = "Player 4",
                        LastName = "Player 4",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 5,
                        FirstName = "Player 5",
                        LastName = "Player 5",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 6,
                        FirstName = "Player 6",
                        LastName = "Player 6",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 7,
                        FirstName = "Player 7",
                        LastName = "Player 7",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 8,
                        FirstName = "Player 8",
                        LastName = "Player 8",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 9,
                        FirstName = "Player 9",
                        LastName = "Player 9",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 10,
                        FirstName = "Player 10",
                        LastName = "Player 10",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 11,
                        FirstName = "Player 11",
                        LastName = "Player 11",
                        TeamId = 1
                    },
                    new Player
                    {
                        Id = 12,
                        FirstName = "Player 12",
                        LastName = "Player 12",
                        TeamId = 1
                    }
                }
            },
            
            new Team
            {
                Id = 2,
                Name = "Team 2",
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        FirstName = "Player 1",
                        LastName = "Player 1",
                        TeamId = 1
                    }

                }


            }
                  

        };

        public static List<Player> Players = Teams.SelectMany(x => x.Players).ToList();
    }
}
