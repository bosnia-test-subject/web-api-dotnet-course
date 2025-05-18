using Microsoft.AspNetCore.Mvc;
using web_api_dotnet_course.Dtos.Fight;
using web_api_dotnet_course.Dtos.Skill;
using web_api_dotnet_course.Services.FightService;

namespace web_api_dotnet_course.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }
        [HttpPost("WeaponAttack")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            var response = await _fightService.WeaponAttack(request);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
        [HttpPost("SkillAttack")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
        {
            var response = await _fightService.SkillAttack(request);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<FightResultDto>>> Fight(FightRequestDto request)
        {
            var response = await _fightService.Fight(request);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<FightResultDto>>> GetHighScore()
        {
            var response = await _fightService.GetHighScore();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}