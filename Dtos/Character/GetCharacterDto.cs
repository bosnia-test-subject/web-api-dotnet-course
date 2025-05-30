using web_api_dotnet_course.Dtos.Skill;
using web_api_dotnet_course.Dtos.Weapon;

namespace web_api_dotnet_course.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string? Name { get; set; } = "Reuf";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto? Weapon { get; set; }
        public List<GetSkillDto>? Skill { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}