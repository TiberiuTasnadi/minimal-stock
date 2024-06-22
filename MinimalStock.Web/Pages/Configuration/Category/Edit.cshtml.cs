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
        public CategoryModel Category { get; set; }

        public void OnGet()
        {
            Category = new CategoryModel
            {
                Name = "Vinilos",
                Fields = new List<FieldModel>
                {
                    new FieldModel
                    {
                        Oid = Guid.NewGuid(),
                        Name = "Artista",
                        Type = FieldType.String,
                    },
                    new FieldModel
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
            return Page();
        }

        public async Task<IActionResult> OnPostAddField()
        {
            Category.Fields.Add(new FieldModel()
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

            return Page();
        }
    }
}
