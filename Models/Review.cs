using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Models;

public class Review
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ReviewId { get; set; }

    public int BookID { get; set; } // Foreign key referencing Books table

    [Required]
    public string ReviewText { get; set; }

    [ForeignKey("BookID")]
    public Books Book { get; set; } // Navigation property to access the related book
}
