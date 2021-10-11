using AdopteUnDev.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Interfaces
{
    public interface IUserBllRepository
    {
        UserBllModel ConnectClient(string email, string password);
        UserBllModel ConnectDeveloppeur(string email, string password);
    }
}
