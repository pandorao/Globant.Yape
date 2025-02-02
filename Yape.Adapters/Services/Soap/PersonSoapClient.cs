using Yape.Entities;
using Yape.Ports;

namespace Yape.Adapters.Services.Soap
{
    public class PersonSoapClient : IPersonSoapClient
    {
        private readonly ServiceReference1.PersonServiceClient _soapClient;

        public PersonSoapClient()
        {
            _soapClient = new ServiceReference1.PersonServiceClient(ServiceReference1.PersonServiceClient.EndpointConfiguration.BasicHttpBinding_IPersonService);
        }

        public async Task<Person> GetPersonByPhoneNumberAsync(string phoneNumber)
        {
            var soapPerson = await _soapClient
                .GetPersonByPhoneNumberAsync(phoneNumber);

            if (soapPerson == null)
                return null;

            return new Person
            {
                CellPhoneNumber = soapPerson.CellPhoneNumber,
                DocumentNumber = soapPerson.DocumentNumber,
                DocumentType = soapPerson.DocumentType,
                LastName = soapPerson.LastName,
                Name = soapPerson.Name
            };
        }
    }
}
