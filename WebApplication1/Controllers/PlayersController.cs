using Core.Dtos;
using Core.Services;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/players")]
    public class PlayersController : ControllerBase
    {

        private PlayerService playerService { get; set; }

        public PlayersController(PlayerService playerService)
        {
            this.playerService = playerService;
        }

        [HttpGet("/get-all")]

        public ActionResult<List<Player>> GetAll()
        {
            var results = playerService.GetAll();

            return Ok(results);
        }
        
        [HttpGet("/get/{playerId}")]

        public ActionResult<Player> GetById(int playerId)
        {
            var result = playerService.GetById(playerId);

            if (result == null)
            {
                return BadRequest("Player not found");
            }  
            
            return Ok(result);
        }

        [HttpPatch("edit-name")]

        public ActionResult<bool> GetById([FromBody] PlayerUpdateDto payload)
        {
            var result = playerService.EditName(payload);

            if (result == false)
            {
                return BadRequest("Player not found");
            }

            return Ok(result);
        }
    }
}
