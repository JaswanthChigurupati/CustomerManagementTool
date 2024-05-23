using CustomerManagement.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerManagement.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(IHttpClientFactory clientFactory, ILogger<IndexModel> logger)
        {
            _httpClient = clientFactory.CreateClient("ApiClient");
            _logger = logger;
        }

        public IList<Customer> Customers { get; set; }

        public async Task OnGetAsync()
        {
            _logger.LogInformation("Fetching customers from API.");
            try
            {
                Customers = await _httpClient.GetFromJsonAsync<IList<Customer>>("api/customer");
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError($"Request failed: {ex.Message}");
                throw;
            }
        }
    }
}
