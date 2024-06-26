namespace MinimalStock.Web.Models
{
    public class ItemsViewModel
    {
        public Guid Oid { get; set; } = Guid.NewGuid();
        public List<FieldViewModel> Fields { get; set; } = new List<FieldViewModel>();
    }
}
