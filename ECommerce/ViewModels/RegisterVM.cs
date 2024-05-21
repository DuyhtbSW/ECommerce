using System.ComponentModel.DataAnnotations;

namespace ECommerce.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Ten Dang Nhap ")]
        [Required(ErrorMessage ="*")]
        [MaxLength(15, ErrorMessage ="Max 20")]
        public string MaKh { get; set; }
        [Display(Name = "Mat Khau ")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        [Display(Name = "Ho Va Ten ")]
        [Required(ErrorMessage = "*")]
        [MaxLength(15, ErrorMessage = "Max 50")]
        public string HoTen { get; set; }
        [Display(Name = "Gioi Tinh")]
        [Required(ErrorMessage = "*")]
        public bool GioiTinh { get; set; } = true;
        [Display(Name = "Ngay Sinh")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }
        [Display(Name = "Dia Chi ")]
        [MaxLength(15, ErrorMessage = "Max 50")]
        public string DiaChi { get; set; }
        [MaxLength(15, ErrorMessage = "Max 24")]
        [Display(Name = "Dien Thoai ")]
        public string DienThoai { get; set; }
        [EmailAddress(ErrorMessage ="Invalid email")]
        [Display(Name = "Email")]
        public string Email { get; set; } 
        [Display(Name = "Hinh Anh")]
        public string? Hinh { get; set; }

    }
}
