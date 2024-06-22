using MinimalStock.ApplicationService.DTOs;
using MinimalStock.ApplicationService.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalStock.ApplicationService.Services
{
    public class CategoryApplicationService : ICategoryApplicationService
    {
        public async Task<IEnumerable<CategoryDto>> GetCategories()
        {
            return new List<CategoryDto>()
            {
                new CategoryDto()
                {
                    Name = "name",
                    Oid = Guid.NewGuid(),
                },
                new CategoryDto()
                {
                    Name = "name2",
                    Oid = Guid.NewGuid(),
                },
                new CategoryDto()
                {
                    Name = "name3",
                    Oid = Guid.NewGuid(),
                },
                new CategoryDto()
                {
                    Name = "name4",
                    Oid = Guid.NewGuid(),
                },
                new CategoryDto()
                {
                    Name = "name5",
                    Oid = Guid.NewGuid(),
                },
                new CategoryDto()
                {
                    Name = "name6",
                    Oid = Guid.NewGuid(),
                },
            };
        }
    }
}
