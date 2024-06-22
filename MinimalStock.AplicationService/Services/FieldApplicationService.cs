using MinimalStock.ApplicationService.DTOs;
using MinimalStock.ApplicationService.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.ApplicationService.Services
{
    public class FieldApplicationService : IFieldApplicationService
    {
        public async Task<IEnumerable<FieldDto>> GetFields()
        {
            return new List<FieldDto>()
            {
                new FieldDto()
                {
                    Name = "Name",
                    Type = Domain.Enums.FieldType.String,
                    Oid = Guid.NewGuid(),
                },
                new FieldDto()
                {
                    Name = "Name2",
                    Type = Domain.Enums.FieldType.Integer,
                    Oid = Guid.NewGuid(),
                },
                new FieldDto()
                {
                    Name = "Name3",
                    Type = Domain.Enums.FieldType.Decimal,
                    Oid = Guid.NewGuid(),
                },
                new FieldDto()
                {
                    Name = "Name4",
                    Type = Domain.Enums.FieldType.DateTime,
                    Oid = Guid.NewGuid(),
                },
            };
        }
    }
}
