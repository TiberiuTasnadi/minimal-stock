using MinimalStock.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.ApplicationService.DTOs
{
    public class FieldDto
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public FieldType Type { get; set; }
    }
}