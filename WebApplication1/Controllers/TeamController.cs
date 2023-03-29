using Core.Dtos;
using Core.Services;
using DataLayer.Dtos;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamController : ControllerBase
    {
        public TeamService teamService { get; set; }

        public TeamController(TeamService teamService)
        {
            this.teamService = teamService;
        }


        [HttpGet("get-all")]
        public ActionResult<List<Team>> GetAll()
        {
            var results = teamService.GetAll();

            return Ok(results);
        }

        [HttpGet("get/{teamId}")]

        public ActionResult<Team> GetById(int teamId)
        {
            var result = teamService.GetById(teamId);

            if (result == null)
            {
                return BadRequest("Team not found");
            }

            return Ok(result);
        }

        //add team

        [HttpPost("add-team")]

        public ActionResult<bool> AddTeam([FromBody] TeamAddDto payload)
        {
            var result = teamService.AddTeam(payload);

            if (result == false)
            {
                return BadRequest("Team not found");
            }

            return Ok(result);
        }

        //add player

        [HttpPost("add-player")]

        public ActionResult<bool> AddPlayer([FromBody] PlayerAddDto payload)
        {
            var result = teamService.AddPlayer(payload);

            if (result == false)
            {
                return BadRequest("Player not found");
            }

            return Ok(result);
        }

        //delete team

        [HttpDelete("delete-team/{teamId}")]

        public ActionResult<bool> DeleteTeam(int teamId)
        {
            var result = teamService.DeleteTeam(teamId);

            if (result == false)
            {
                return BadRequest("Team not found");
            }

            return Ok(result);
        }

      
        
        
        





    }
}
