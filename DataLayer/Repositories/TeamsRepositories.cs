using DataLayer.Entities;
namespace DataLayer.Repositories
{
    public class TeamsRepository
    {
        public List<Team>GetAll()
        {
            var result = DbContext.Teams;

            return result;
        }

        public Team GetById(int teamId)
        {
            var result = DbContext.Teams
                .Where(e => e.Id == teamId)
                .FirstOrDefault();

            return result;
        }

        //add team
        public bool AddTeam(Team team)
        {
            if (team == null || team.Name == null)
            {
                return false;
            }

            DbContext.Teams.Add(team);

            return true;
        }

        //delete team

        public bool DeleteTeam(Team team)
        {
            if (team == null || team.Name == null)
            {
                return false;
            }

            DbContext.Teams.Remove(team);

            return true;
        }

        //add player

        public bool AddPlayer(Player player)
        {
            if (player == null || player.FirstName == null || player.LastName == null)
            {
                return false;
            }

            var team = DbContext.Teams
                .Where(e => e.Id == player.TeamId)
                .FirstOrDefault();

            if (team == null) return false;

            team.Players.Add(player);

            return true;
        }


    }
}
