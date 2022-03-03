using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notely_App.ConnectDb;
using Notely_App.Model;

namespace Notely_App.Pages.views;
[BindProperties]
  public class UpdateModel : PageModel
     {
    private readonly ApplicationData _db;

    public Items Items { get; set; }
    public UpdateModel(ApplicationData db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        Items = _db.Items.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _db.Items.Update(Items);
            await _db.SaveChangesAsync();
            TempData["Success"] = "SuccessFully Updated";
            return RedirectToAction("Index");
        }
        return Page();
    }
}

