using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MinimalStock.Web.Models;

namespace MinimalStock.Web.Pages.Configuration.Category
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public CategoryModel Category { get; set; }

        public void OnGet()
        {
            Category = new CategoryModel();
            Category.Fields.Add(new FieldModel());
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) 
            {
                return Page();
            }

            return RedirectToPage("/Configuration/Index");
        }

        public async Task<IActionResult> OnPostAddField()
        {
            Category.Fields.Add(new FieldModel());
            return Page();
        }

        public async Task<IActionResult> OnPostCancel()
        {
            return RedirectToPage("/Configuration/Index");
        }
    }
}
