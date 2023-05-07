using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface INhanVienRepository : IRepository<NhanVien>
    {
    }
    public class NhanVienRepository : Repository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(EXDbContext context) : base(context)
        {
        }
    }
}
