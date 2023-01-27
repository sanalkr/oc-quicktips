using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using TestWebApplication.Options;

namespace TestWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IOptions<ConnectionStrings> _connectionStrings;

        public IndexModel(ILogger<IndexModel> logger, IOptions<ConnectionStrings> connectionStrings)
        {
            _logger = logger;
            _connectionStrings = connectionStrings;
        }

        public void OnGet()
        {
            _logger.LogInformation("On Get Init");
            string connection = _connectionStrings.Value.DefaultConnection;
            string apiKey = Settings.ApiKey;

            _logger.LogInformation("On Get End");

        }
    }
}