using AdopteUnDev.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Interfaces
{
    public interface IDeveloppeurBllRepository
    {
        public DeveloppeurBllModel LoginDev(string email, string password);

        void RegisterDev(DeveloppeurBllModel entity);
    }
}
