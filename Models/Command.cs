using System.ComponentModel.DataAnnotations;

namespace CommandBase.Models
{
    public class Command
    {
        [Key]
        public int id {get; set;}
        
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string Line { get; set; }
        
        [Required]
        public string Platform { get; set; }
    }
}