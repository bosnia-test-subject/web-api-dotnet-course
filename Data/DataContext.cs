using Microsoft.EntityFrameworkCore;

namespace web_api_dotnet_course.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters => Set<Character>();
    }
}