using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yape.WcfService.Models
{
    public class Person
    {
        public string CellPhoneNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
    }
}