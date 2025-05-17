using web_api_dotnet_course.Dtos.Fight;

namespace web_api_dotnet_course.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}