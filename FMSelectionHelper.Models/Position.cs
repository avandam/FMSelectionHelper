// ReSharper disable InconsistentNaming
namespace FMSelectionHelper.Models
{
    public class Position
    {
        public PositionType PositionType { get; }

        private readonly List<Role> possibleRoles;
        public List<Role> PossibleRoles => possibleRoles;

        public Position(PositionType positionType, List<Role> possibleRoles)
        {
            PositionType = positionType;
            this.possibleRoles = possibleRoles;
        }

        public bool IsRoleValid(RoleType roleType)
        {
            return possibleRoles.Any(role => role.RoleType == roleType);
        }

        public override string ToString()
        {
            return PositionType.ToDescriptionString();
        }
    }
}