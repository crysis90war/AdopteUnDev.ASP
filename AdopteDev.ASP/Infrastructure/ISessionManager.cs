using AdopteDev.ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Infrastructure
{
    public interface ISessionManager
    {
        UserModel CurrentUser { get; set; }
    }
}
