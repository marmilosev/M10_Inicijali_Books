using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Book
    {

        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string? Title { get; set; }

        public int AuthorId { get; set; }

        public int PublisherId { get; set; }

    }
}
