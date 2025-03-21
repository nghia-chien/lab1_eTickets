using System.ComponentModel.DataAnnotations;    
namespace eTickets.Models
{
    public class EmailMarketingModel
    {

        [Required(ErrorMessage = "Vui lòng nhập email của bạn")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên của bạn")]
        public string Name { get; set; }
    }
}
