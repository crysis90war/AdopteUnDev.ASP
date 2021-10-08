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
        private readonly IDeveloppeurDalRepository _DeveloppeurDalRepository;
        public DeveloppeurBllRepository(IDeveloppeurDalRepository service)
        {
            _DeveloppeurDalRepository = service;
        }

        public void RegisterDev(DeveloppeurBllModel entity)
        {
            _DeveloppeurDalRepository.RegisterDev(entity.BllToDal());
        }
    }
}
