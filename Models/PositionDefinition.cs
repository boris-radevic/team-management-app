using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagementApp.Models
{
    public class PositionDefinition
    {
        public Guid Id {get; set;}
        public int StructuralId {get; set;}
        public string Title {get; set;} = string.Empty;
        public Guid RoleId {get; set;}
        public ICollection<Position>? Positions {get; set;}
        public Guid TeamId {get; set;}
    }
}