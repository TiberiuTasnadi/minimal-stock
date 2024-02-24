using MinimalStock.Domain.Entities.Base;
using MinimalStock.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.Domain.Entities
{
    public class Field : BaseEntitiy
    {
        public string Name { get; set; }
        public FieldType Type { get; set; }
    }
}
