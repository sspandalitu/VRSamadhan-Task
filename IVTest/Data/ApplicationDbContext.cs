using IVTest.Models;
using Microsoft.EntityFrameworkCore;

namespace IVTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<IVMd> ShyamTb { get; set; }

        public DbSet<IVMdlTwo> TableTwo { get; set; }
        public DbSet<FinalMdl> FinalTb { get; set; }
    }
}
