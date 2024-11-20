using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagementApp.Models
{
    public class Tag
    {
        public Guid Id {get; set;}
        public string Title {get; set;} = string.Empty;
    }
}