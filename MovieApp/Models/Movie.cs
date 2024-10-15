namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        // Use the 'required' modifier to ensure these properties are set when the object is created
        public required string Title { get; set; }
        public required string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
