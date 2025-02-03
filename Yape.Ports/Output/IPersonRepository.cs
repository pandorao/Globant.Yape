using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yape.Entities;

namespace Yape.Ports.Output
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();
        Task AddAsync(Person person);
    }
}
