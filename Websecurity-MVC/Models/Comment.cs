using System.ComponentModel.DataAnnotations;

namespace Websecurity_MVC.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Text { get; set; }
    }
}
