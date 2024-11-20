using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagementApp.Models
{
    public class Team
    {
        public Guid Id {get; set;}
        public int StructuralId {get; set;}
        public string Title {get; set;} = string.Empty;
        public ICollection<Team>? SubTeams{get; set;}
        public Guid RoleId {get; set;}
        public ICollection<PositionDefinition> PositionDefinitions {get; set;} = null!;
        public Guid ParentTeamId {get; set;}
    }
}