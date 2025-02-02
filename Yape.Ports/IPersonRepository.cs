using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yape.Entities;

namespace Yape.Ports
{
    public interface IPersonRepository
    {
        Task AddAsync(Person person);
    }
}
