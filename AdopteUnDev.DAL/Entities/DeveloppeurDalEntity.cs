﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Models
{
    public class DeveloppeurDalEntity
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Pswd { get; set; }
    }
}
