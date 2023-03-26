using DataLayer.Entities;
using System.Net.NetworkInformation;

namespace DataLayer
{
    
    public static class DbContext
    {
        static void Main() { }
        public static List<Team> Teams = new List<Team>
        {
            new Team
            {
                Id=1,
                Name="Manchester United",
                Players = new List<Player>
                {
                    new Player
                    {
                        Id=1,
                        FirstName="David",
                        LastName="De Gea",
                        Position="Goalkeeper",
                        TeamId=1,
                        Stats = new List<Stats>
                        {
                            new Stats
                            {
                                Id=1,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=10,
                                YellowCards=4,
                                RedCards=0,
                                PlayerId=1,
                                Tournament= Tournament.ChampionsLeague
                            },
                            
                            new Stats
                            {
                                Id=2,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=30,
                                YellowCards=2,
                                RedCards=0,
                                PlayerId=1,
                                Tournament= Tournament.PremierLeague
                            }
                        }
                    },
                    new Player
                    {
                        Id=2,
                        FirstName="Aaron",
                        LastName="Wan-Bissaka",
                        Position="Defender",
                        TeamId=1,
                        Stats = new List<Stats>
                        {
                            new Stats
                            {
                                Id=3,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=10,
                                YellowCards=3,
                                RedCards=0,
                                PlayerId=2,
                                Tournament= Tournament.ChampionsLeague

                            },
                            new Stats
                            {
                                Id=4,
                                GoalsScored=1,
                                Assists=3,
                                Appearances=50,
                                YellowCards=7,
                                RedCards=3,
                                PlayerId=2,
                                Tournament= Tournament.PremierLeague
                            }
                        }
                    },
                    new Player
                    {
                        Id=3,
                        FirstName="Victor",
                        LastName="Lindelof",
                        Position="Defender",
                        TeamId=1,
                        Stats = new List<Stats>
                        {
                            new Stats
                            {
                                Id=5,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=0,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=3
                            }
                        }
                    },
                    new Player
                    {
                        Id=4,
                        FirstName="Harry",
                        LastName="Maguire",
                        Position="Defender",
                        TeamId=1,
                        Stats = new List<Stats>
                        {
                            new Stats
                            {
                                Id=6,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=10,
                                YellowCards=0,
                                RedCards=3,
                                PlayerId=4,
                                Tournament= Tournament.ChampionsLeague

                            },
                            new Stats
                            {
                                Id=7,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=30,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=4,
                                Tournament= Tournament.PremierLeague
                            }

                        }
                    },
                    new Player
                    {
                        Id=5,
                        FirstName="Luke",
                        LastName="Shaw",
                        Position="Defender",
                        TeamId=1,
                        Stats = new List<Stats>
                        {
                            new Stats
                            {
                                Id=8,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=0,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=5,
                                Tournament= Tournament.ChampionsLeague
                            }
                        }
                    }
                }
                 

            },
            new Team
            {
                Id=2,
                Name="Manchester City",
                Players = new List<Player>
                {
                    new Player
                    {
                        Id=6,
                        FirstName="Ederson",
                        LastName="Moraes",
                        Position="Goalkeeper",
                        TeamId=2,
                        Stats = new List<Stats>
                        {
                            new Stats
                            {
                                Id=9,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=10,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=6,
                                Tournament= Tournament.ChampionsLeague
                            },
                            new Stats
                            {
                                Id=10,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=30,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=6,
                                Tournament= Tournament.PremierLeague
                            }
                        }
                    },
                    new Player
                    {
                        Id=7,
                        FirstName="Kyle",
                        LastName="Walker",
                        Position="Defender",
                        TeamId=2,
                        Stats = new List<Stats>
                        {
                            new Stats
                            {
                                Id=11,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=10,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=7,
                                Tournament= Tournament.ChampionsLeague
                            },
                            new Stats
                            {
                                Id=12,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=30,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=7,
                                Tournament= Tournament.PremierLeague
                            }
                        }
                    },
                    new Player
                    {
                        Id=8,
                        FirstName="John",
                        LastName="Stones",
                        Position="Defender",
                        TeamId=2,
                        Stats = new List<Stats>
                        {
                            new Stats
                            {
                                Id=13,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=10,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=8,
                                Tournament= Tournament.ChampionsLeague
                            },
                            new Stats
                            {
                                Id=14,
                                GoalsScored=0,
                                Assists=0,
                                Appearances=30,
                                YellowCards=0,
                                RedCards=0,
                                PlayerId=8,
                                Tournament= Tournament.PremierLeague
                            }
                        }
                    }
                }
            }




        };

        public static List<Player> Players = Teams.SelectMany(x => x.Players).ToList();

        public static List<Stats> Stats = Teams.SelectMany(x => x.Players).SelectMany(x => x.Stats).ToList();
    }
}
