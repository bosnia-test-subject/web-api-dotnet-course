using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using web_api_dotnet_course.Dtos.Character;
using web_api_dotnet_course.Dtos.Weapon;
using web_api_dotnet_course.Services.WeaponService;

namespace web_api_dotnet_course.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            var response = await _weaponService.AddWeapon(newWeapon);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}