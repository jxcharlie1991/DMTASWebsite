using System.ComponentModel.DataAnnotations;

namespace DMTASWebsite.Models
{
    public class PrintDivisionModel
    {
        [Required]
        public string DivisionTitle { get; set; }
    }
}
