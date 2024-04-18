namespace WebAPICourse.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        //ICollection is not editable a List is
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
