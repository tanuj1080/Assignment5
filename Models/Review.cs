namespace Bookstore.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string BookTitle { get; set; }
        public string ReviewText { get; set; }
        public string ReviewerName { get; set; } // Optional
    }

}
