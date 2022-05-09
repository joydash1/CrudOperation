using Microsoft.EntityFrameworkCore;

namespace BankTransection.Models
{
    public class TransectionDbContext:DbContext
    {
        public TransectionDbContext(DbContextOptions<TransectionDbContext>options):base(options)
        {
                
        }
        public DbSet<Transection>Transections  { get; set; }
    }
}
