using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteDev.ASP.Models.Forms
{
    public class ClientLoginForm
    {
        [Required]
        [DisplayName("E-mail :")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Mot de passe :")]
        [DataType(DataType.Password)]
        public string Pswd { get; set; }
    }
}
