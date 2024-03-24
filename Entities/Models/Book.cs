using CSDemoProject1.Enums;
using System.ComponentModel.DataAnnotations;

namespace CSDemoProject1.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublicationYear { get; set; }
        public Status Status { get; set; }
        public BookType Type { get; set; }
    }
}
