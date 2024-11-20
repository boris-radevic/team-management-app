using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagementApp.Models
{
    public class InviteData
    {
        public bool AutoConfirm {get; set;}
        public string Email {get; set;} = string.Empty;
        public string Name {get; set;} = string.Empty;
    }
}