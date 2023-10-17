using System.ComponentModel.DataAnnotations;

namespace IVTest.Models
{
    public class IVMdlTwo
    {
        [Key]
        public int id {  get; set; }
        [Required]
        public string Subjects { get; set; }

    }
}
