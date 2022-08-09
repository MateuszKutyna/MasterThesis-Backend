using Microsoft.EntityFrameworkCore;

namespace MasterThesis_Backend.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Steel> Steels { get; set; }
    }
}
