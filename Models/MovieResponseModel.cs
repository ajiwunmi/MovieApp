using System.Text.Json.Serialization;

namespace ReactMovieApp.Models
{
    public class MovieResponseModel
    {
       

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("year")]
        public string? Year { get; set; }

        [JsonPropertyName("rated")]
        public string? Rated { get; set; }

        [JsonPropertyName("release")]
        public string? Released { get; set; }
        [JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        [JsonPropertyName("genre")]
        public string? Genre { get; set; }
        [JsonPropertyName("director")]
        public string? Director { get; set; }
        [JsonPropertyName("writer")]
        public string? Writer { get; set; }
      
        

    }
}
