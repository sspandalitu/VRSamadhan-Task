using System.ComponentModel.DataAnnotations;

namespace IVTest.Models
{
    public class IVMd
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
    }
}
