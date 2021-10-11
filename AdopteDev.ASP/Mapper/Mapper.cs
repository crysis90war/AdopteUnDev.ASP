using AdopteDev.ASP.Models;
using AdopteDev.ASP.Models.Forms;
using AdopteUnDev.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Mapper
{
    internal static class Mapper
    {
        /*---------------------------------------------Developpeur-------------------------------------------------*/
        internal static DeveloppeurBllModel AspToBll(this DevRegisterForm entity)
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

        internal static DeveloppeurModel BllToAsp(this DeveloppeurBllModel model)
        {
            return new DeveloppeurModel()
            {
                Id = model.Id,
                LastName = model.LastName,
                FirstName = model.FirstName,
                BirthDate = model.BirthDate,
                Email = model.Email,
            };
        }

        /*---------------------------------------------Client-------------------------------------------------*/
        internal static ClientBllModel AspToBll(this ClientRegisterForm entity)
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
                Email =  model.Email
            };
        }
    }
}
