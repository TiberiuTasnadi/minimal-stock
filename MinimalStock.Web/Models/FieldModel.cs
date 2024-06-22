using MinimalStock.Domain.Enums;

namespace MinimalStock.Web.Models
{
    public class FieldModel
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public FieldType Type { get; set; }
    }
}
