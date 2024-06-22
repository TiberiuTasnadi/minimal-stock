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
        public Models.ConfigurationModel Configuration { get; set; }

        public async void OnGet()
        {
            var categories = new List<Models.CategoryModel>()
            {
                new Models.CategoryModel
                {
                    Oid = Guid.NewGuid(),
                    Name = "Vinilos",
                    Fields = new List<Models.FieldModel>
                    {
                        new Models.FieldModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Artista",
                            Type = Domain.Enums.FieldType.String,
                        },
                        new Models.FieldModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Quantitat",
                            Type = Domain.Enums.FieldType.Integer,
                        },
                    },
                },
                new Models.CategoryModel
                {
                    Oid = Guid.NewGuid(),
                    Name = "Llibres",
                    Fields = new List<Models.FieldModel>
                    {
                        new Models.FieldModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Autor",
                            Type = Domain.Enums.FieldType.String,
                        },
                        new Models.FieldModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Pàgines",
                            Type = Domain.Enums.FieldType.Integer,
                        },
                    },
                },
            };

            Configuration = new Models.ConfigurationModel
            {
                Categories = categories,
            };
        }
    }
}
