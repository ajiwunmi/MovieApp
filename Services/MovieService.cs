using System.Text.Json;
using ReactMovieApp.Models;
using ReactMovieApp.Repositories;


namespace ReactMovieApp.Services
{
    public class MovieService(IHttpClientFactory clientFactory, IConfiguration configuration, ILogger<MovieService> logger) : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IConfiguration _configuration = configuration;
        protected readonly IHttpClientFactory _clientFactory = clientFactory;
        private readonly ILogger<MovieService> _logger = logger;

        public async Task<IEnumerable<MovieResponseModel>> SearchMoviesAsync(string title)
        {
           
            var apiKey = _configuration["OMDB:ApiKey"];
            var baseUrl = _configuration["OMDB:BaseUrl"];
            var endpointUrl = new Uri($"{baseUrl}?apikey={apiKey}&s={title}", UriKind.Relative);
          

            try
            {
                using (var client = _clientFactory.CreateClient())
                {
                    var response = await client.GetAsync(endpointUrl);
                    response.EnsureSuccessStatusCode();

                    using (var contentStream = await response.Content.ReadAsStreamAsync())
                    {
                        return await JsonSerializer.DeserializeAsync<IEnumerable<MovieResponseModel>>(contentStream);
                    }

                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError($"An error occurred getting all countries: {ex}");
                throw;
            }
        }
     

        public async Task<Movie> GetMovieDetailsAsync(int id)
        {
            return await _movieRepository.GetMovieQueryByTitleAsync((id);
        }

        

    }
}
        

