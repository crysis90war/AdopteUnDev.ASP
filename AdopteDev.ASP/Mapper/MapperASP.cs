using AdopteDev.ASP.Models;
using AdopteDev.ASP.Models.Forms;
using AdopteUnDev.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Mapper
{
    internal static class MapperASP
    {
        /*---------------------------------------------Developpeur-------------------------------------------------*/
        internal static DeveloppeurBllModel ASPToBll(this DevRegisterForm entity)
        {
            return new DeveloppeurBllModel()
            {
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                Tel = entity.Tel,
                Email = entity.Email,
                Pswd = entity.Pswd
            };
        }

        /*---------------------------------------------Client-------------------------------------------------*/
        internal static ClientBllModel ASPToBll(this ClientRegisterForm entity)
        {
            return new ClientBllModel()
            {
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                Compagny = entity.Compagny,
                Tel = entity.Tel,
                Email = entity.Email,
                Pswd = entity.Pswd
            };
        }

        internal static ClientModel BllToAsp(this ClientBllModel model)
        {
            return new ClientModel
            {
                Id =  model.Id,
                LastName =  model.LastName,
                FirstName =  model.FirstName,
                Compagny =  model.Compagny,
                Tel =  model.Tel,
                Email =  model.Email,
                Pswd =  model.Pswd
            };
        }
    }
}
