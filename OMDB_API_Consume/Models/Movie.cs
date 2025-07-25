namespace OMDB_API_Consume.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Poster { get; set; }
        public string imdbRating { get; set; }

        // Add these two fields for error and status handling
        public string Response { get; set; }  // "True" or "False"
        public string Error { get; set; }     // e.g., "Movie not found!"
    }
}
