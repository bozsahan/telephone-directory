using Directory.Models;
using Microsoft.EntityFrameworkCore;

namespace Directory.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<TelephoneDirectory> TelephoneDirectorys { get; set; }
    }
}
