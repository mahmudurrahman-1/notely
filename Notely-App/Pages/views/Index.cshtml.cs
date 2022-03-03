using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notely_App.ConnectDb;
using Notely_App.Model;

namespace Notely_App.Pages.views
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationData _db;
        public IEnumerable<Items> Items { get; set; }
        public IndexModel(ApplicationData db)
        {
            _db = db;
        }


        public void OnGet()
        {
            Items = _db.Items;
        }

    }
}
