using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Required]
        public string ReviewText { get; set; }

        public int BookID { get; set; } // Foreign Key


    }
}
