using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string AuthorName { get; set; } = string.Empty;

        [ForeignKey("BookId")]
        public virtual ICollection<Book>? Books { get; set; }
    }
}
