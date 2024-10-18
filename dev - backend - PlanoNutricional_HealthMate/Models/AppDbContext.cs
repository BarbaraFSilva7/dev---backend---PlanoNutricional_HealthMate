using dev___backend___PlanoNutricional_HealthMate.Views;
using Microsoft.EntityFrameworkCore;

namespace dev___backend___PlanoNutricional_HealthMate.Models
{
    public class AppDbContext: DbContext

    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
        public DbSet<PlanoNutricional> PlanoNutricional { get; set; }
    }
}
