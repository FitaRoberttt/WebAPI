using System;
using System.Collections.Generic;
using Core.Dtos;
using DataLayer.Dtos;
using DataLayer.Entities;
using DataLayer.Repositories;

namespace Core.Services
{
    public class TeamService
    {
        public TeamsRepository teamsRepository { get; set; }

        public TeamService(TeamsRepository teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }
        
        public List<Team> GetAll()
        {
            var results = teamsRepository.GetAll();
            return results;
        }

        public Team GetById(int id)
        {
            var result = teamsRepository.GetById(id);
            return result;
        }

        //add team
        public bool AddTeam(TeamAddDto payload)
        {
            if (payload == null || payload.Name == null)
            {
                return false;
            }
            var team = new Team
            {
                Name = payload.Name
            };
            teamsRepository.AddTeam(team);
            return true;
        }

        //delete team
        public bool DeleteTeam(int id)
        {
            var team = teamsRepository.GetById(id);
            if (team == null)
            {
                return false;
            }
            teamsRepository.DeleteTeam(team);
            return true;
        }

        //add player

        public bool AddPlayer(PlayerAddDto payload)
        {
            if (payload == null || payload.FirstName == null || payload.LastName == null)
            {
                return false;
            }

            var player = new Player
            {
                FirstName = payload.FirstName,
                LastName = payload.LastName,
                Position = payload.Position,
                TeamId = payload.TeamId
            };

            teamsRepository.AddPlayer(player);

            return true;

        }






    }
}
