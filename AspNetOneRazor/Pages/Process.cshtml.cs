using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace AspNetOneRazor.Pages
{
    public class ProcessModel : PageModel
    {
        public Process Process { get; set; }
        public void OnGet()
        {
            Process = Process.GetCurrentProcess();
        }
    }
}
