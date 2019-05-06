using System;

namespace worthWatchingAPI.Modles
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterImage { get; set; }
        public decimal IMDBRating { get; set; }
        public int RTRating { get; set; }
        public int MetacriticRating { get; set; }
    }
}