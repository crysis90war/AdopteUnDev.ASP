using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Models.Forms
{
    public class DevRegisterForm
    {
        [Required]
        [DisplayName("Nom :")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Prenom:")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Date naissance :")]
        public DateTime BirthDate { get; set; }

        [Required]
        [DisplayName("telephone :")]
        public string Tel { get; set; }

        [Required]
        [DisplayName("E-mail :")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("Mot de passe :")]
        [DataType(DataType.Password)]
        public string Pswd { get; set; }
    }
}
