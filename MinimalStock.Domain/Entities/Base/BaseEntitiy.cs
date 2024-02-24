using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.Domain.Entities.Base
{
    public class BaseEntitiy
    {
        [Key]
        public Guid Oid { get; set; }
    }
}
