using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Yape.WcfService.Models;

namespace Yape.WcfService
{
    [ServiceContract]
    public interface IPersonService
    {

        [OperationContract]
        Person GetPersonByPhoneNumber(string cellPhoneNumber);
    }
}
