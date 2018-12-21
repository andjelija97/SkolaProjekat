using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektniCentarSkole.Models
{
    public class RoleViewModel
    {
        public RoleViewModel()
        {
        }

        public RoleViewModel(ApplicationRole role)
        {
            Id = role.Id;
            Name = role.Name;
        }

        public string Id { get; set; }

        [Required]
        [RegularExpression("^[A-Za-z]$", ErrorMessage = "Unesite samo slova za naziv uloga")]
        public string Name { get; set; }
    }

}
