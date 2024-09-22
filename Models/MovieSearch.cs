namespace ReactMovieApp.Models
{
    public class MovieSearch
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public DateTime SearchTime { get; set; } =  DateTime.Now;
    }
}
