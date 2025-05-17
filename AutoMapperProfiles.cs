using AutoMapper;
using web_api_dotnet_course.Dtos.Character;
using web_api_dotnet_course.Dtos.Skill;
using web_api_dotnet_course.Dtos.Weapon;

namespace web_api_dotnet_course
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}