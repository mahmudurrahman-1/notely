using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notely_App.ConnectDb;
using Notely_App.Model;

namespace Notely_App.Pages.views;
[BindProperties]

    public class DeleteModel : PageModel
    {
    private readonly ApplicationData _db;

    public Items Items { get; set; }
    public DeleteModel(ApplicationData db)
    {
        _db = db;
    }
    public void OnGet(int id)
        {
            Items = _db.Items.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            _db.Items.Remove(Items);
            await _db.SaveChangesAsync();
        TempData["Removed"] = "SuccessFully Deleted";

        return RedirectToAction("Index");
        }
    }



