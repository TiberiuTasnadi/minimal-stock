using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MinimalStock.Domain.Enums;
using MinimalStock.Web.Models;

namespace MinimalStock.Web.Pages.Configuration.Category
{
    public class EditModel : PageModel
    {
        [FromRoute]
        public Guid Id { get; set; }

        [BindProperty]
        public CategoryViewModel Category { get; set; }

        public void OnGet()
        {
            Category = new CategoryViewModel
            {
                Name = "Vinilos",
                Fields = new List<FieldViewModel>
                {
                    new FieldViewModel
                    {
                        Oid = Guid.NewGuid(),
                        Name = "Artista",
                        Type = FieldType.String,
                    },
                    new FieldViewModel
                    {
                        Oid = Guid.NewGuid(),
                        Name = "Quantitat",
                        Type = FieldType.Integer,
                    },
                },
            };
        }

        public async Task<IActionResult> OnPostEdit()
        {
            return RedirectToPage("/Configuration/Index");
        }

        public async Task<IActionResult> OnPostDelete()
        {
            return RedirectToPage("/Configuration/Index");
        }

        public async Task<IActionResult> OnPostCancel()
        {
            return RedirectToPage("/Configuration/Index");
        }

        public async Task<IActionResult> OnPostAddField()
        {
            Category.Fields.Add(new FieldViewModel()
            {
                Oid = Guid.NewGuid(),
            });

            return Page();
        }

        public async Task<IActionResult> OnPostRemoveField(Guid fieldId)
        {
            var field = Category.Fields.FirstOrDefault(f => f.Oid == fieldId);
            if (field != null)
            {
                Category.Fields.Remove(field);
            }

            ModelState.Clear();
            return Page();
        }
    }
}
