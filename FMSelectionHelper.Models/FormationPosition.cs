using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSelectionHelper.Models
{
    public class FormationPosition
    {
        public int Index { get; }
        public Position Position { get; }
        public Role Role { get; }

        public FormationPosition(int index, Position position, Role role)
        {
            if (!position.IsRoleValid(role.RoleType))
            {
                throw new ArgumentException($"Position {position} can not fulfill role {role}");
            }
            Index = index;
            Position = position;
            Role = role;
        }
    }
}
