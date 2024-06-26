using MinimalStock.Domain.Enums;

namespace MinimalStock.Web.Models
{
    public class FieldViewModel
    {
        public Guid Oid { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public FieldType Type { get; set; } = FieldType.String;
        public object? Value { get; set; }
    }
}
