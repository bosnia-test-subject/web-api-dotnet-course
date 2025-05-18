using AutoMapper;
using web_api_dotnet_course.Dtos.Character;
using web_api_dotnet_course.Dtos.Fight;
using web_api_dotnet_course.Dtos.Skill;
using web_api_dotnet_course.Dtos.Weapon;

namespace web_api_dotnet_course
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}