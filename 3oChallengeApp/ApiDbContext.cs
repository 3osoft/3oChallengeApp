using Microsoft.EntityFrameworkCore;

namespace _3oChallenge
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base()
        {

        }
    }
}