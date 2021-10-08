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
    public class ClientBllRepository : IClientBllRepository
    {
        private readonly IClientDalRepository _clientDalRepository;
        public ClientBllRepository(IClientDalRepository clientDalRepository)
        {
            _clientDalRepository = clientDalRepository;
        }

        public ClientBllModel LoginClient(string email, string password)
        {
            return _clientDalRepository.LoginClient(email, password)?.DalToBll();
        }

        public void RegisterClient(ClientBllModel entity)
        {
            _clientDalRepository.RegisterClient(entity.BllToDal());
        }
    }
}
