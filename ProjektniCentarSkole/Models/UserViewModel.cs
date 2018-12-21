using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektniCentarSkole.Models
{
    public class UserViewModel
    {

        public UserViewModel()
        {
        }

        public UserViewModel(ApplicationUser user)
        {
            Id = user.Id;
            LastName = user.LastName;
            UserName = user.UserName;
            PravaPristupa = user.PravaPristupa;
            Email = user.Email;
            Password = user.Password;
        }

        public string Id { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PravaPristupa { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}