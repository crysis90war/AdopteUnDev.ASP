using AdopteUnDev.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface IUserRepository
    {
        UserEntity ConnectClient(string email, string password);
        UserEntity ConnectDeveloppeur(string email, string password);
    }
}
