using Yape.Entities;

namespace Yape.Ports.Output
{
    public interface IPersonSoapClient
    {
        Task<Person> GetPersonByPhoneNumberAsync(string phoneNumber);

    }
}
