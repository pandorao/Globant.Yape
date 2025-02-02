using Yape.Entities;

namespace Yape.Ports
{
    public interface IPersonSoapClient
    {
        Task<Person> GetPersonByPhoneNumberAsync(string phoneNumber);

    }
}
