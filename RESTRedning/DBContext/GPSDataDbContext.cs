
using Microsoft.EntityFrameworkCore;
using RESTRedning.Models;

namespace RESTRedning.DBContext
{
    public class GPSDataDbContext : DbContext
    {
        public GPSDataDbContext(DbContextOptions<GPSDataDbContext> options) : base(options)
        {

        }

        public DbSet<GPSData> GPSDataB { get; set; }
    }
}
