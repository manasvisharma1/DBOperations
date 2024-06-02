using Microsoft.EntityFrameworkCore;

namespace DBOperation.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { 
        
        }
    }
}
