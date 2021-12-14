using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace AspNetOneRazor.Pages
{
    public class ThreadModel : PageModel
    {
        [FromQuery(Name = "culture")]
        public string? Culture { get; set; }
        public void OnGet()
        {
            if (!string.IsNullOrEmpty(Culture))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Culture);
            }
        }
    }
}
