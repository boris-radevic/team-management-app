using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagementApp.Models
{
    public class Position
    {
        public Guid Id {get; set;}
        public int StructuralId {get; set;}
        public string Title {get; set;} = string.Empty;
        public User User {get; set;} = null!;
        public Role Role {get; set;} = null!;
        public int Status {get; set;}
        public InviteData InviteData {get; set;} = null!;
        public Guid PositionDefinitionId {get; set;}
    }
}