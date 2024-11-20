using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagementApp.Models
{
    public class Data
    {
        public ICollection<Team> Teams {get; set;} = null!;
        public ICollection<PositionDefinition> PositionDefinitions {get; set;} = null!;
    }
}