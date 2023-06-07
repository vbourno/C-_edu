using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebEmptyApp.Pages
{
    public class StudentsModel : PageModel
    {
        public IEnumerable<string>? Students { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Coding Factory";
            Students = new[]
            {
                "Alice W.", "Bob D.", "Costas A."
            };
        }
    }
}
