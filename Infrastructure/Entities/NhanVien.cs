using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    [Table("nNhanVien")]
    public class NhanVien
    {
        [Key]
        public int uID { get; set; }
        public string uHovaTen { get; set; }
        public bool uGioiTinh { get; set; }
        public DateTime uNgaySinh { get; set; }
        public string uSoDienThoai { get; set; } 
        public string uDiaChi { get; set; }


    }
    
}
