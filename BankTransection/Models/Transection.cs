using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransection.Models
{
    public class Transection
    {
        [Key]
        [Required]
        [Display(Name = "Transtion ID")]
        public string TranstionID { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Display(Name = "Account Number")]
        [Required]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Benicifiary Name")]
        [Required]
        public string BenicifiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bank Name")]
        [Required]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [Display(Name = "Swift Code")]
        [Required]
        public string SwiftCode { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Amount")]
        [Required]
        public int Amount { get; set; }
    }
}
