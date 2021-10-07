using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBug.Data;
using MyBug.Models;

namespace MyBug.Pages.Bugs
{
    public class IndexModel : PageModel
    {
        public IList<Bug> Bugs { get; set; }
        public void OnGet([FromServices]BugDbContext db)
        {
            Bugs = db.Bugs.ToList();
        }
    }
}
