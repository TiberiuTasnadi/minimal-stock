using MinimalStock.ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.ApplicationService.Services.Contracts
{
    public interface IFieldApplicationService
    {
        Task<IEnumerable<FieldDto>> GetFields();
    }
}
