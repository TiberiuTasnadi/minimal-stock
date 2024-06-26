namespace MinimalStock.Web.Models
{
    public class IndexViewModel
    {
        public List<string> AllCategories { get; set; } = new List<string>();
        public string AllCategoriesJson { get; set; } = string.Empty;
        public string SelectedCategory { get; set; } = string.Empty;
        public List<ItemsViewModel> Items { get; set; } = new List<ItemsViewModel>();
    }
}
