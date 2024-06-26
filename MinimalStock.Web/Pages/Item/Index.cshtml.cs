using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MinimalStock.Domain.Entities;
using MinimalStock.Domain.Enums;
using MinimalStock.Web.Models;
using Newtonsoft.Json;

namespace MinimalStock.Web.Pages.Item
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public IndexViewModel IndexViewModel { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var allCategories = new List<string>
            {
                "Vinilos",
                "Llibres",
            };

            IndexViewModel = new IndexViewModel()
            {
                AllCategories = allCategories,
                AllCategoriesJson = JsonConvert.SerializeObject(allCategories),
                SelectedCategory = "Vinilos",
                Items = MockVinyls(),
            };
        }

        public async Task<IActionResult> OnPost()
        {
            if (!string.IsNullOrEmpty(IndexViewModel.AllCategoriesJson))
            {
                IndexViewModel.AllCategories = JsonConvert.DeserializeObject<List<string>>(IndexViewModel.AllCategoriesJson) ?? new List<string>();
            }

            if (IndexViewModel.SelectedCategory == "Llibres")
            {
                IndexViewModel.Items = MockBooks();
            }
            else if (IndexViewModel.SelectedCategory == "Vinilos")
            {
                IndexViewModel.Items = MockVinyls();
            }

            return Page();
        }

        private List<ItemsViewModel> MockVinyls()
        {
            return new List<ItemsViewModel>
            {
                new ItemsViewModel
                {
                    Fields = new List<FieldViewModel>
                    {
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Títol",
                            Type = FieldType.String,
                            Value = "Abbey Road",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Artista",
                            Type = FieldType.String,
                            Value = "The Beatles",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Quantitat",
                            Type = FieldType.Integer,
                            Value = 1,
                        },
                    },
                },
                new ItemsViewModel
                {
                    Fields = new List<FieldViewModel>
                    {
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Títol",
                            Type = FieldType.String,
                            Value = "Disco 9",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Artista",
                            Type = FieldType.String,
                            Value = "Soto Asa",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Quantitat",
                            Type = FieldType.Integer,
                            Value = 2,
                        },
                    },
                },
                new ItemsViewModel
                {
                    Fields = new List<FieldViewModel>
                    {
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Títol",
                            Type = FieldType.String,
                            Value = "Holly Hell",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Artista",
                            Type = FieldType.String,
                            Value = "Architects",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Quantitat",
                            Type = FieldType.Integer,
                            Value = 1,
                        },
                    },
                },
            };
        }

        private List<ItemsViewModel> MockBooks()
        {
            return new List<ItemsViewModel>
            {
                new ItemsViewModel
                {
                    Fields = new List<FieldViewModel>
                    {
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Titol",
                            Type = FieldType.String,
                            Value = "1984",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Autor",
                            Type = FieldType.String,
                            Value = "George Orwell",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Data Publicació",
                            Type = FieldType.Integer,
                            Value = DateTime.Now.Year,
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Preu",
                            Type = FieldType.Integer,
                            Value = 7.99,
                        },
                    },
                },
                new ItemsViewModel
                {
                    Fields = new List<FieldViewModel>
                    {
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Titol",
                            Type = FieldType.String,
                            Value = "Clean Code",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Autor",
                            Type = FieldType.String,
                            Value = "Uncle Bob",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Data Publicació",
                            Type = FieldType.Integer,
                            Value = DateTime.Now.Year,
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Preu",
                            Type = FieldType.Integer,
                            Value = 59,
                        },
                    },
                },
                new ItemsViewModel
                {
                    Fields = new List<FieldViewModel>
                    {
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Titol",
                            Type = FieldType.String,
                            Value = "Hola que tal?",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Autor",
                            Type = FieldType.String,
                            Value = "Tiberiu Tasnadi",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Data Publicació",
                            Type = FieldType.Integer,
                            Value = DateTime.Now.Year,
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Preu",
                            Type = FieldType.Integer,
                            Value = 10,
                        },
                    },
                },
                new ItemsViewModel
                {
                    Fields = new List<FieldViewModel>
                    {
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Titol",
                            Type = FieldType.String,
                            Value = "Que passaria si...?",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Autor",
                            Type = FieldType.String,
                            Value = "Randall Munroe",
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Data Publicació",
                            Type = FieldType.Integer,
                            Value = DateTime.Now.Year,
                        },
                        new FieldViewModel
                        {
                            Oid = Guid.NewGuid(),
                            Name = "Preu",
                            Type = FieldType.Integer,
                            Value = 20,
                        },
                    },
                },
            };
        }
    }
}
