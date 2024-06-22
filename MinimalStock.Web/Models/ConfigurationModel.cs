using MinimalStock.ApplicationService.DTOs;

namespace MinimalStock.Web.Models
{
    public class ConfigurationModel
    {
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}
