using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }

}
