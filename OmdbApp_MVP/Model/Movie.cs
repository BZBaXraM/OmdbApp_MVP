namespace OmdbApp_MVP.Model
{
    internal class Movie // Model
    {
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? imdbID { get; set; }
        public string? Type { get; set; }
        public string? Poster { get; set; }

        public override string ToString()
        {
            return $"{Title} - Release date - {Year}";
        }
    }
}