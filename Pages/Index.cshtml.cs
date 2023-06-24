using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace britonforms.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public bool hasData = false;
        public string first_name = "";
        public string last_name = "";
        public string feedback = "";

        public void OnGet()
        {

        }
        public void OnPost(string message)
        {
            hasData = true;
            first_name = Request.Form["first_name"];
            last_name = Request.Form["last_name"];
            feedback = Request.Form["feedback"];

        }
    }
}