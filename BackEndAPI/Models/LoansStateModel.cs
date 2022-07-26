using System.ComponentModel.DataAnnotations;

namespace BackEndAPI.Models
{
    public class LoansStateModel
    {

        [Key]
        public int LoansStatesId { get; set; }

        [Display(Name = "Loan State Name")]
        public string LoansStateName { get; set; } = null!;

        //public virtual ICollection<Loan> Loans { get; set; }
    }
}
