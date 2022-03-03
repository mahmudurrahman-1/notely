using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notely_App.ConnectDb;
using Notely_App.Model;

namespace Notely_App.Pages.views;

    public class CreateModel : PageModel
    {
    private readonly ApplicationData _db;
    [BindProperty]

    public Items Items { get; set; }
    public CreateModel(ApplicationData db)
    {
        _db = db;
    }
        public void OnGet()
        {
        }

    public async Task<IActionResult> OnPost()
    {
        if(Items.Name == null || Items.Company==null || Items.ItemsNo==0 || Items.ItemsAm == 0)
        {
            ModelState.AddModelError("Warning"," Every field is required"); 
        }

        if (ModelState.IsValid)
        {
            await _db.Items.AddAsync(Items);
            await _db.SaveChangesAsync();
            TempData["Success"] = "SuccessFully Added";

            return RedirectToAction("Index");
        }
        return Page();
    }
    }

