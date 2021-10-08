using AdopteDev.ASP.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Infrastructure
{
    public class SessionManager : ISessionManager
    {
        private readonly ISession _session;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        public UserModel CurrentUser
        {
            get
            {
                if (!_session.Keys.Contains(nameof(CurrentUser)))
                    return null;

                if (_session.GetString(nameof(CurrentUser)) is null)
                    return null;

                return JsonConvert.DeserializeObject<UserModel>(_session.GetString(nameof(CurrentUser)));
            }
            set
            {
                _session.SetString(nameof(CurrentUser), JsonConvert.SerializeObject(value));
            }
        }

    }
}
