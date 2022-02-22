namespace FMSelectionHelper.Models
{
    public class Formation
    {
        private readonly List<FormationPosition> selection;
        public IReadOnlyCollection<FormationPosition> Selection => selection.AsReadOnly();

        // For now fix the formation to the default one.
        public Formation()
        {
            selection = new List<FormationPosition>();
            AddPosition(new FormationPosition(0, PositionCollection.Instance.GetPosition(PositionType.GK), RoleCollection.Instance.GetRole(RoleType.SweeperKeeper, Duty.Defend)));
            AddPosition(new FormationPosition(1, PositionCollection.Instance.GetPosition(PositionType.DL), RoleCollection.Instance.GetRole(RoleType.WingBack, Duty.Support)));
            AddPosition(new FormationPosition(2, PositionCollection.Instance.GetPosition(PositionType.DCL), RoleCollection.Instance.GetRole(RoleType.CentralDefender, Duty.Defend)));
            AddPosition(new FormationPosition(3, PositionCollection.Instance.GetPosition(PositionType.DCR), RoleCollection.Instance.GetRole(RoleType.CentralDefender, Duty.Defend)));
            AddPosition(new FormationPosition(4, PositionCollection.Instance.GetPosition(PositionType.DR), RoleCollection.Instance.GetRole(RoleType.WingBack, Duty.Support)));
            AddPosition(new FormationPosition(5, PositionCollection.Instance.GetPosition(PositionType.MCL), RoleCollection.Instance.GetRole(RoleType.DeepLyingPlaymaker, Duty.Support)));
            AddPosition(new FormationPosition(6, PositionCollection.Instance.GetPosition(PositionType.MCR), RoleCollection.Instance.GetRole(RoleType.BoxToBoxMidfielder, Duty.Support)));
            AddPosition(new FormationPosition(7, PositionCollection.Instance.GetPosition(PositionType.AML), RoleCollection.Instance.GetRole(RoleType.InsideForward,  Duty.Attack)));
            AddPosition(new FormationPosition(8, PositionCollection.Instance.GetPosition(PositionType.AMC), RoleCollection.Instance.GetRole(RoleType.ShadowStriker, Duty.Attack)));
            AddPosition(new FormationPosition(9, PositionCollection.Instance.GetPosition(PositionType.AMR), RoleCollection.Instance.GetRole(RoleType.InsideForward, Duty.Support)));
            AddPosition(new FormationPosition(10, PositionCollection.Instance.GetPosition(PositionType.ST), RoleCollection.Instance.GetRole(RoleType.AdvancedForward, Duty.Attack)));
        }

        public void AddPosition(FormationPosition position)
        {
            if (position.Index < 0 || position.Index > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(position.Index), "Index in formation should be between 0 and 10");
            }
            if (selection.Any(selectionItem => selectionItem.Index == position.Index))
            {
                throw new ArgumentException($"An item with index {position.Index} already exists");
            }
            selection.Add(position);
        }

        public void RemovePosition(FormationPosition position)
        {
            if (selection.Contains(position))
            {
                selection.Remove(position);
            }
        }
    }
}
