using Yape.Entities;
using Yape.Entities.Base;
using Yape.Ports.Input;
using Yape.Ports.Output;

namespace Yape.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPersonSoapClient _personSoapClient;

        public PersonService(
            IPersonRepository personRepository,
            IPersonSoapClient personSoapClient)
        {
            _personRepository = personRepository;
            _personSoapClient = personSoapClient;
        }

        public async Task<ServiceResult<List<Person>>> GetAllAsync()
        {
            return new ServiceResult<List<Person>>()
            {
                ResponseObject = await _personRepository.GetAllAsync()
            };
        }

        public async Task<ServiceResult<Person>> AddAsync(Person person)
        {
            var serviceResult = new ServiceResult<Person>();

            if (!person.IsValid(out var erros))
            {
                serviceResult.AddModelError(erros);
                return serviceResult;
            }

            var soapPerson = await _personSoapClient
                .GetPersonByPhoneNumberAsync(person.CellPhoneNumber);
            if (soapPerson == null)
            {
                serviceResult.AddModelError("", "User not found in external soap service");
                return serviceResult;
            }

            if (soapPerson.DocumentType != person.DocumentType ||
                soapPerson.DocumentNumber != person.DocumentNumber)
            {
                serviceResult.AddModelError("", "The DocumentType and DocumentNumber fields could not be matched with the external soap service");
                return serviceResult;
            }

            if (await _personRepository.PersonExists(person))
            {
                serviceResult.AddModelError("", "User already exists");
                return serviceResult;
            }

            person.Id = Guid.NewGuid().ToString();
            await _personRepository.AddAsync(person);
            serviceResult.ResponseObject = person;
            return serviceResult;
        }
    }
}
