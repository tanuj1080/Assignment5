using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace Bookstore.Models;

    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenreID { get; set; } // Primary Key

        //[Required]
        //[StringLength(255)]
        public string GenreName { get; set; }
    }
