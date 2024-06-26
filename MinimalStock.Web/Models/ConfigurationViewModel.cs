using MinimalStock.ApplicationService.DTOs;

namespace MinimalStock.Web.Models
{
    public class ConfigurationViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
