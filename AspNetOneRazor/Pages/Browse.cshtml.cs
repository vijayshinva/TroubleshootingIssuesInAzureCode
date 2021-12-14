using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetOneRazor.Pages
{
    public class BrowseModel : PageModel
    {
        [FromQuery(Name = "path")]
        public string Path { get; set; }
        public IEnumerable<FileSystemInfo> FileSystemInfos { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrEmpty(Path))
            {
                FileSystemInfos = DriveInfo.GetDrives().Select(d => d.RootDirectory);
            }
            else
            {
                FileSystemInfos = new DirectoryInfo(Path).GetFileSystemInfos();
            }
        }
    }
}
