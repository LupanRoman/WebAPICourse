namespace WebAPICourse.Models
{
    public class Pokemon
    {
        // This is a modal-A class with bunch of props in it
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        //This is a one to many relation in SQL
        public ICollection<Review> Reviews { get; set; }     
    }
}
