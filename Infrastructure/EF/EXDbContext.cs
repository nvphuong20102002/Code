using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF
{
    public class EXDbContext : DbContext
    {
        public EXDbContext(DbContextOptions<EXDbContext> options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<NhanVien> nhanvien { get; set; }
    }
}   
