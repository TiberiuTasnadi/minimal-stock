using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MinimalStock.ApplicationService.Services.Contracts;

namespace MinimalStock.Web.Pages.Configuration
{
    public class IndexModel : PageModel
    {
        private ICategoryApplicationService _categoryApplicationService;
        private IFieldApplicationService _fieldApplicationService;

        public IndexModel(ICategoryApplicationService categoryApplicationService,
            IFieldApplicationService fieldApplicationService)
        {
            _categoryApplicationService = categoryApplicationService;
            _fieldApplicationService = fieldApplicationService;
        }

        [BindProperty]
        public Models.ConfigurationViewModel Configuration { get; set; }

        public async void OnGet()
        {
            var categories = new List<Models.CategoryViewModel>()
            {
                new Models.CategoryViewModel
                {
                    Oid = Guid.NewGuid(),
                    Name = "Vinilos",
                    Fields = new List<Models.FieldViewModel>
                    {
                        new Models.FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Artista",
                            Type = Domain.Enums.FieldType.String,
                        },
                        new Models.FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Quantitat",
                            Type = Domain.Enums.FieldType.Integer,
                        },
                    },
                },
                new Models.CategoryViewModel
                {
                    Oid = Guid.NewGuid(),
                    Name = "Llibres",
                    Fields = new List<Models.FieldViewModel>
                    {
                        new Models.FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Autor",
                            Type = Domain.Enums.FieldType.String,
                        },
                        new Models.FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Pàgines",
                            Type = Domain.Enums.FieldType.Integer,
                        },
                    },
                },
            };

            Configuration = new Models.ConfigurationViewModel
            {
                Categories = categories,
            };
        }

        public IActionResult OnPostDeleteCategory(Guid categoryId)
        {
            return RedirectToPage("/Configuration/Index");
        }
    }
}
