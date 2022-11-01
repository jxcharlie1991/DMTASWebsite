using System.ComponentModel.DataAnnotations;

namespace DMTASWebsite.Models
{
    public class SignageDivisionModel
    {
        [Required]
        public string DivisionTitle { get; set; }
    }
}
