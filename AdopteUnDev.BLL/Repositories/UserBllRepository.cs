using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Interfaces;
using AdopteUnDev.BLL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Repositories
{
    public class UserBllRepository : IUserBllRepository
    {
        private readonly IUserRepository _userRepository;

        public UserBllRepository(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserBllModel ConnectClient(string email, string password)
        {
            return _userRepository.ConnectClient(email, password).DalToBll();
        }

        public UserBllModel ConnectDeveloppeur(string email, string password)
        {
            return _userRepository.ConnectDeveloppeur(email, password).DalToBll();
        }
    }
}
