using TeamManagementApp.Models;
using TeamManagementApp.Services.Contracts;

namespace TeamManagementApp.Services.Implementations
{
    public class HierarchyService : IHierarchyService
    {
        public List<GridNode> ConvertToGridNodes(Data data)
        {
            var nodes = new List<GridNode>();

            foreach (var team in data.Teams)
            {
                nodes.Add(ConvertTeamToGridNode(team));
            }

            foreach (var posDef in data.PositionDefinitions) 
            {
                nodes.Add(ConvertPosDefToGridNode(posDef));
            }

            return nodes;
        }

        private GridNode ConvertTeamToGridNode(Team team)
        {
            var node = new GridNode
            {
                Id = team.Id,
                Title = team.Title,
                Type = "Team"
            };

            if (team.SubTeams?.Any() == true)
            {
                foreach (var subTeam in team.SubTeams)
                {
                    node.Children.Add(ConvertTeamToGridNode(subTeam));
                }
            }

            if(team.PositionDefinitions?.Any() == true)
            {
                foreach (var posDef in team.PositionDefinitions)
                {
                    node.Children.Add(ConvertPosDefToGridNode(posDef));
                }
            }

            return node;
        }


        private GridNode ConvertPosDefToGridNode(PositionDefinition posDef) 
        {
            var node = new GridNode
            {
                Id = posDef.Id,
                Title = posDef.Title,
                Type = "PositionDefinition"
            };

            var PosDefAdditionalData = new PositionDefinitionAdditionalData();
            if (posDef.Positions?.Any() == true)
            {
                
                int filledPositionCounter = 0;
                foreach(var position in posDef.Positions)
                {
                    if(position.Status == 2){
                        filledPositionCounter++;
                    }
                    node.Children.Add(new GridNode
                    {
                        Id = position.Id,
                        Title = position.Title,
                        Type = "Position",
                        AdditionalData = position.Status == 2
                            ? new PositionAdditionalData
                            {
                                FirstName = position.InviteData.Name,
                                Email = position.InviteData.Email,
                                Status = position.Status,
                            }
                            : new PositionAdditionalData
                            {
                                Status = position.Status
                            }
                    });
                }
                PosDefAdditionalData.TotalCount = posDef.Positions.Count;
                PosDefAdditionalData.FilledCount = filledPositionCounter;
            }
            node.AdditionalData = PosDefAdditionalData;

            return node;
        }

    }
}
