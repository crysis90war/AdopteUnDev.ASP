using AdopteUnDev.BLL.Models;
using AdopteUnDev.DAL.Entities;
using AdopteUnDev.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.BLL.Mapper
{
    internal static class Mapper
    {
        /*---------------------------------------Developpeur-----------------------------------------------*/
        internal static DeveloppeurDalEntity BllToDal(this DeveloppeurBllModel entity)
        {
            return new DeveloppeurDalEntity()
            {
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                Tel = entity.Tel,
                Email = entity.Email,
                Pswd = entity.Pswd
            };
        }

        internal static DeveloppeurBllModel DalToBll(this DeveloppeurDalEntity entity)
        {
            return new DeveloppeurBllModel()
            {
                Id = entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                Tel = entity.Tel,
                Email = entity.Email
            };
        }

        /*---------------------------------------Client-----------------------------------------------*/
        internal static ClientDalEntity BllToDal(this ClientBllModel entity)
        {
            return new ClientDalEntity()
            {
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                Compagny = entity.Compagny,
                Tel = entity.Tel,
                Email = entity.Email,
                Pswd = entity.Pswd
            };
        }

        internal static ClientBllModel DalToBll(this ClientDalEntity entity)
        {
            return new ClientBllModel()
            {
                Id = entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                Compagny = entity.Compagny,
                Tel = entity.Tel,
                Email = entity.Email
            };
        }

        /* --------------------------------------- User ----------------------------------------------- */

        public static UserEntity BllToDal(this UserBllModel model)
        {
            return new UserEntity()
            {
                Id = model.Id,
                LastName = model.LastName,
                FirstName = model.FirstName,
                Email = model.Email,
                Token = model.Token
            };
        }

        public static UserBllModel DalToBll(this UserEntity entity)
        {
            return new UserBllModel()
            {
                Id = entity.Id,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                Email = entity.Email,
                Token = entity.Token
            };
        }
    }
}
