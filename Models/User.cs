using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagementApp.Models
{
    public class User
    {
        public Guid Id {get; set;}
        public string Email {get; set;} = string.Empty;
        public string UserName {get; set;} = string.Empty;
        public string FirstName {get; set;} = string.Empty;
        public string SecondName {get; set;} = string.Empty;
        public string ImageUrl {get; set;} = string.Empty;
        public string PhoneNumber {get; set;} = string.Empty;
        public bool PhoneNumberConfirmed {get; set;}
        public ICollection<Role>? Roles{get; set;}
    }
}