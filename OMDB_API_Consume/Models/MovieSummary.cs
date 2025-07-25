namespace OMDB_API_Consume.Models
{
    public class MovieSummary
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Poster { get; set; }
    }

    public class MovieSearchResult
    {
        public List<MovieSummary> Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
        public string Error { get; set; }
    }

}
