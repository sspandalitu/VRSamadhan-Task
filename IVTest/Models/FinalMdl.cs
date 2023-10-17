using System.ComponentModel.DataAnnotations;

namespace IVTest.Models
{
    public class FinalMdl
    {
        [Key]
        public int id {  get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
