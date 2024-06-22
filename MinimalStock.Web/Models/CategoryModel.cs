using MinimalStock.ApplicationService.DTOs;

namespace MinimalStock.Web.Models
{
    public class CategoryModel
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public List<FieldModel> Fields { get; set; } = new List<FieldModel>();
    }
}
