using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yape.Adapters.Services.Repositories.Persistance;
using Yape.Entities;
using Yape.Ports.Output;

namespace Yape.Adapters.Services.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PersonRepository(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _dbContext.People.ToListAsync();
        }

        public async Task AddAsync(Person person)
        {
            _dbContext.Add(person);
            await _dbContext.SaveChangesAsync();
        }
    }
}
