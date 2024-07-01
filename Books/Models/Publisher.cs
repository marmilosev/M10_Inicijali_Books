using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        [Required]
        [StringLength(200)]
        public string? PublisherName { get; set; }

        [ForeignKey("BookId")]
        public virtual ICollection<Book>? Books { get; set; }
    }
}
