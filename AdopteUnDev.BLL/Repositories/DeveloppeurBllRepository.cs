using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Mapper;
using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Repositories
{
    public class DeveloppeurBllRepository : IDeveloppeurBllRepository
    {
        private readonly IDeveloppeurDalRepository _developpeurDalRepository;
        public DeveloppeurBllRepository(IDeveloppeurDalRepository service)
        {
            _developpeurDalRepository = service;
        }

        public DeveloppeurBllModel LoginDev(string email, string password)
        {
            return _developpeurDalRepository.LoginDev(email, password)?.DalToBll();
        }

        public void RegisterDev(DeveloppeurBllModel entity)
        {
            _developpeurDalRepository.RegisterDev(entity.BllToDal());
        }
    }
}
