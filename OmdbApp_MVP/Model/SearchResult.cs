namespace OmdbApp_MVP.Model
{
    internal class SearchResult // Model
    {
        public List<Movie>? Search { get; set; }
        public int TotalResults { get; set; }
        public string? Response { get; set; }
    }
}
