using System.ComponentModel.DataAnnotations;

namespace BackEndAPI.Models
{
    public class CorrencyModel
    {

        [Key]
        public int CorrencyId { get; set; }

        [Required(ErrorMessage = "Corrency name is Required")]
        [Display(Name = "Corrency Name")]
        public string CorrencyName { get; set; } = null!;

        //public virtual ICollection<Loan> Loans { get; set; }

    }
}
