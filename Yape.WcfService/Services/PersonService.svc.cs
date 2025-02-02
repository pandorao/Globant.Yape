using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Yape.WcfService.Models;
using Yape.WcfService.Repositories;

namespace Yape.WcfService
{
    public class PersonService : IPersonService
    {
        public Person GetPersonByPhoneNumber(string cellPhoneNumber)
        {
            return UnitOfWork
                .PersonRepository
                .GetPersonByPhoneNumber(cellPhoneNumber);
        }
    }
}
