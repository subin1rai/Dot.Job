using JobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Data
{
    public class TitleDbContext : DbContext
    {
        public TitleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<JobTitle> JobTitles { get; set; }
    }
}
