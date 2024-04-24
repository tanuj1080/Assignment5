using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace Bookstore.Models;
    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; } // Primary Key

        
        public string BookTitle { get; set; }

        
        public decimal Price { get; set; }

        
        public string Author { get; set; }

        
        public Genre GenreID { get; set; }

        
        public Genre Genre { get; set; }
    }
