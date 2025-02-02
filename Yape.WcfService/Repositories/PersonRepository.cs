using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yape.WcfService.Models;
using Yape.WcfService.Persistence;

namespace Yape.WcfService.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetPersonByPhoneNumber(string phoneNumber);
    }

    public class PersonRepository : IPersonRepository
    {
        private readonly PersistenceContext _context;

        public PersonRepository(PersistenceContext context)
        {
            context = _context;
        }

        public List<Person> GetPersonByPhoneNumber(string phoneNumber)
        {
            return _context
                .People
                .Where(x => x.CellPhoneNumber == phoneNumber)
                .ToList();
        }
    }
}