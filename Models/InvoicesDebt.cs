using System.ComponentModel.DataAnnotations;

namespace CompositeCRM.Models
{
    public class InvoicesDebt
    {
        public int Id { get; set; }
        [Required]
        public string DepartmentNameDebt { get; set; }
        [Required]
        public string DateInvoicesDebt { get; set; }
        [Required]
        public int InvoiceNumberDebt { get; set; }
        [Required]
        public string ClientNameDebt { get; set; }
        [Required]
        public decimal InvoiceAmountDebt { get; set; }
        [Required]
        public string EmployeeFullNameDebt { get; set; }
        [Required]
        public int INNClientDebt { get; set; }
        [Required]
        public string InvoiseStatusDebt { get; set; }


    }
}
