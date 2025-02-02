using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yape.WcfService.Persistence;
using Yape.WcfService.Repositories;

namespace Yape.WcfService
{
    public static class UnitOfWork
    {
        #region Persistence
        private static PersistenceContext _PersistenceContext;

        public static PersistenceContext PersistenceContext 
        { 
            get
            {
                if (_PersistenceContext == null)
                {
                    _PersistenceContext = new PersistenceContext();
                }

                return _PersistenceContext;
            }
        }
        #endregion

        #region Repositories
        private static IPersonRepository _PersonRepository;
        public static IPersonRepository PersonRepository 
        { 
            get
            {
                if (_PersonRepository == null)
                {
                    _PersonRepository = new PersonRepository(PersistenceContext);
                }
                return _PersonRepository;
            }
        }
        #endregion
    }
}