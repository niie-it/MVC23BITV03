using Microsoft.EntityFrameworkCore;

namespace Buoi08_EFCoreCodeFirst.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        //Khai báo map entity <--> table
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
    }
}
