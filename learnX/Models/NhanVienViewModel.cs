using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace learnX.Models
{

    public class NhanVienViewModel
    {
        public NhanVienViewModel()
        {
        }

        [DisplayName("ID")]
        public int uID { get; set; }

        [DisplayName("Họ và tên")]
        [MaxLength(100, ErrorMessage = "Họ và tên không quá 100 ký tự.")]
        public string uHovaTen { get; set; }

        [DisplayName("Giới tính")]
        public bool uGioiTinh { get; set; }

        [DisplayName("Ngày sinh ")]
        public DateTime uNgaySinh { get; set; }

        [DisplayName("Điện thoại")]
        [MaxLength(32, ErrorMessage = "Điện thoại không quá 32 ký tự.")]
        public string uSoDienThoai { get; set; }

        [DisplayName("Địa chỉ")]
        [MaxLength(100, ErrorMessage = "Điện thoại không quá 100 ký tự.")]
        public string uDiaChi { get; set; }
    }

}
