using ReactMovieApp.Models;
using ReactMovieApp.Repositories;


namespace ReactMovieApp.Services
{
    public class MovieService : IMovieService
    {
       
        private readonly IMovieRepository _movieRepository;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public MovieService(IMovieRepository movieRepository, HttpClient httpClient, IConfiguration configuration)
        {
            _movieRepository = movieRepository;
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<IEnumerable<Movie>> SearchMoviesAsync(string title)
        {
            var apiKey = _configuration["OMDB:ApiKey"];
            var baseUrl = _configuration["OMDB:BaseUrl"];
            var response = await _httpClient.GetStringAsync($"{baseUrl}?apikey={apiKey}&s={title}");
            // Process and return movies (deserialize the response)
        }

        public async Task<Movie> GetMovieDetailsAsync(int id)
        {
            return await _movieRepository.GetMovieByIdAsync(id);
        }

     }
}
        

