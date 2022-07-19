using System.ComponentModel.DataAnnotations;

namespace CompositeCRM.Models
{
    public class Document
    {
        public int Id { get; set; }
        [Required]
        public string Clients { get; set; }
        [Required]
        public string TypeDoc { get; set; }
        [Required]
        public string DateOfAdded { get; set; }
        [Required]
        public string Employer { get; set; }
 
    }
}
