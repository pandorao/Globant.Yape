using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yape.Entities;
using Yape.Entities.Base;

namespace Yape.Ports.Input
{
    public interface IPersonService
    {
        Task<ServiceResult<List<Person>>> GetAllAsync();
        Task<ServiceResult<Person>> AddAsync(Person person);
    }
}
