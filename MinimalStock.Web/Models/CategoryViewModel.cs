using MinimalStock.ApplicationService.DTOs;

namespace MinimalStock.Web.Models
{
    public class CategoryViewModel
    {
        public Guid Oid { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public List<FieldViewModel> Fields { get; set; } = new List<FieldViewModel>();
    }
}
