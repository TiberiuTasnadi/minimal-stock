using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.ApplicationService.DTOs
{
    public class CategoryDto
    {
        public Guid Oid { get; set; }

        public string Name { get; set; }

        public List<FieldDto> Fields { get; set; }
    }
}