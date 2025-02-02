using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yape.WcfService.Models;

namespace Yape.WcfService.Persistence
{
    public class PersistenceContext
    {

        public PersistenceContext()
        {
            // Dummy information of people for testing purposes
            People = new List<Person>()
            {
                new Person()
                {
                    CellPhoneNumber = "3002906178",
                    Name = "Juan",
                    LastName = "Pérez",
                    DocumentType = "DNI",
                    DocumentNumber = "12345678"
                },
                new Person()
                {
                    CellPhoneNumber = "300458695",
                    Name = "María",
                    LastName = "González",
                    DocumentType = "DNI",
                    DocumentNumber = "87654321"
                },
                new Person()
                {
                    CellPhoneNumber = "300458696",
                    Name = "Carlos",
                    LastName = "Sánchez",
                    DocumentType = "CC",
                    DocumentNumber = "98765432"
                },
                new Person()
                {
                    CellPhoneNumber = "3004586912",
                    Name = "Ana",
                    LastName = "Ramírez",
                    DocumentType = "CC",
                    DocumentNumber = "1234567"
                },
                new Person()
                {
                    CellPhoneNumber = "3004586923",
                    Name = "Luis",
                    LastName = "Martínez",
                    DocumentType = "DNI",
                    DocumentNumber = "11223344"
                }
            };
        }


        public List<Person> People { get; set; }
    }
}