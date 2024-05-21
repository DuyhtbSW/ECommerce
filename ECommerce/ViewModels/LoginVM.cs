using System.ComponentModel.DataAnnotations;

namespace ECommerce.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Ten Dang Nhap")]
        [Required(ErrorMessage ="*")]
         

        public string UserName { get; set; }
        [Display(Name = "Mat Khau")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
