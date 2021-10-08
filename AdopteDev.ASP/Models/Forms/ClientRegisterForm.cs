using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Models.Forms
{
    public class ClientRegisterForm
    {
        [Required]
        [DisplayName("Nom :")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Prenom :")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Societer :")]
        public string Compagny { get; set; }

        [Required]
        [DisplayName("telephone :")]
        public string Tel { get; set; }

        [Required]
        [DisplayName("E-mail :")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Mot de passe :")]
        [DataType(DataType.Password)]
        public string Pswd { get; set; }
    }
}
