using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yape.WcfService.Persistence;
using Yape.WcfService.Repositories;

namespace Yape.WcfService
{
    public class UnitOfWork
    {
        #region Persistence
        private PersistenceContext _PersistenceContext;

        public PersistenceContext PersistenceContext 
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
        private IPersonRepository _PersonRepository;
        public IPersonRepository PersonRepository 
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