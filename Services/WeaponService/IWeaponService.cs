using web_api_dotnet_course.Dtos.Character;
using web_api_dotnet_course.Dtos.Weapon;

namespace web_api_dotnet_course.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}