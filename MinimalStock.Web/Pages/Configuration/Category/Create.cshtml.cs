using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MinimalStock.Web.Models;

namespace MinimalStock.Web.Pages.Configuration.Category
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public CategoryViewModel Category { get; set; }

        public void OnGet()
        {
            Category = new CategoryViewModel();
            Category.Fields.Add(new FieldViewModel());
        }

        public async Task<IActionResult> OnPostCreate()
        {
            if (!ModelState.IsValid) 
            {
                return Page();
            }

            return RedirectToPage("/Configuration/Index");
        }

        public async Task<IActionResult> OnPostAddField()
        {
            Category.Fields.Add(new FieldViewModel());
            return Page();
        }

        public async Task<IActionResult> OnPostCancel()
        {
            return RedirectToPage("/Configuration/Index");
        }
    }
}
