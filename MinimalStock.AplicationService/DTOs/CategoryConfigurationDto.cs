using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.ApplicationService.DTOs
{
    public class CategoryConfigurationDto
    {
        public CategoryDto Category { get; set; }
        public FieldDto Field { get; set; }
    }
}
