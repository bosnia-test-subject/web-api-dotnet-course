namespace web_api_dotnet_course.Dtos.Character
{
    public class AddCharacterDto
    {
        public string? Name { get; set; } = "Reuf";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}