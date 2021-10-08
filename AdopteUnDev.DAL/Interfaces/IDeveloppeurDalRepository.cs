using AdopteUnDev.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Interfaces
{
    public interface IDeveloppeurDalRepository
    {
        // Register
        void RegisterDev(DeveloppeurDalEntity entity);
    }
}
