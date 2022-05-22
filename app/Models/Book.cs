using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class Book
    {

        public Book()
        {

        }

        [Key]
        public int book_id { get; set; }
        [Required]
        public string? book_name { get; set; }
        public string? genre { get; set; }
        public string? author_name { get; set; }
        public string? publisher_name { get; set; }
        public string? language { get; set; }
        public int? no_of_pages { get; set; }
        public string? book_description { get; set; }
        public string? img_url { get; set; }
        public Category? Category { get; set; }
        public Author? Author { get; set; }
        public Publisher? Publisher { get; set; }
    }
}
