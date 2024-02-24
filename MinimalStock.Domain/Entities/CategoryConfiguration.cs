using MinimalStock.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.Domain.Entities
{
    public class CategoryConfiguration : BaseEntitiy
    {
        public Category Category { get; set; }
        public Field Field { get; set; }
    }
}
