// ReSharper disable StringLiteralTypo
namespace FMSelectionHelper.Models
{
    public sealed class PositionCollection
    {
        public static PositionCollection Instance { get; } = new PositionCollection();

        private readonly List<Position> positions;

        static PositionCollection()
        {

        }

        private PositionCollection()
        {
            positions = new List<Position>();
            FillPositions();
        }

        private void FillPositions()
        {
            positions.Add(new Position(PositionType.GK, GetGoalKeeperPossibleRoles()));
            positions.Add(new Position(PositionType.WBL, GetWingBackPossibleRoles()));
            positions.Add(new Position(PositionType.DL, GetBackPossibleRoles()));
            positions.Add(new Position(PositionType.DC, GetDefenderPossibleRoles()));
            positions.Add(new Position(PositionType.DCL, GetDefenderPossibleRoles()));
            positions.Add(new Position(PositionType.DCR, GetDefenderPossibleRoles()));
            positions.Add(new Position(PositionType.DR, GetBackPossibleRoles()));
            positions.Add(new Position(PositionType.WBR, GetWingBackPossibleRoles()));
            positions.Add(new Position(PositionType.DM, GetDefensiveMidfielderRoles()));
            positions.Add(new Position(PositionType.ML, GetMidfielderFlankRoles())); 
            positions.Add(new Position(PositionType.MC, GetMidfielderRoles())); 
            positions.Add(new Position(PositionType.MCR, GetMidfielderRoles())); 
            positions.Add(new Position(PositionType.MCL, GetMidfielderRoles()));
            positions.Add(new Position(PositionType.MR, GetMidfielderFlankRoles()));
            positions.Add(new Position(PositionType.AML, GetWingerRoles()));
            positions.Add(new Position(PositionType.AMC, GetAttackingMidfielderRoles()));
            positions.Add(new Position(PositionType.AMR, GetWingerRoles()));
            positions.Add(new Position(PositionType.ST, GetStrikerRoles()));
        }

        private List<Role> GetStrikerRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.AdvancedForward));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Poacher));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.FalseNine));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.CompleteForward));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Trequartista));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.DeepLyingForward));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.PressingForward));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.TargetForward));

            return result;
        }

        private List<Role> GetAttackingMidfielderRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.ShadowStriker));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.AttackingMidfielder));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.AdvancedPlaymaker));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Trequartista));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Enganche));

            return result;
        }

        private List<Role> GetWingerRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Winger));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.InvertedWinger));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.InsideForward));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.AdvancedPlaymaker));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Trequartista));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Raumdeuter));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.WideTargetForward));

            return result;
        }

        private List<Role> GetMidfielderRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Mezzala));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.AdvancedPlaymaker));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.CentralMidfielder));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.RoamingPlaymaker));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.DeepLyingPlaymaker));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.BoxToBoxMidfielder));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Carrilero));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.BallWinningMidfielder));

            return result;
        }

        private List<Role> GetMidfielderFlankRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Winger));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.InvertedWinger));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.WidePlaymaker));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.DefensiveWinger));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.WideMidfielder));

            return result;
        }

        private List<Role> GetDefensiveMidfielderRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Anchor));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.DefensiveMidfielder));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.HalfBack));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.BallWinningMidfielder));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.SegundoVolante));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.DeepLyingPlaymaker));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Regista));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.RoamingPlaymaker));

            return result;
        }

        private List<Role> GetDefenderPossibleRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.NoNonsenseCentreBack));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.CentralDefender));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.BallPlayingDefender));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.WideCentreBack));

            return result;
        }

        private List<Role> GetBackPossibleRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.FullBack));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.NoNonsenseFullBack));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.WingBack));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.CompleteWingBack));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.InvertedWingBack));

            return result;
        }

        private List<Role> GetWingBackPossibleRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.WingBack));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.CompleteWingBack));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.InvertedWingBack));

            return result;
        }

        private List<Role> GetGoalKeeperPossibleRoles()
        {
            List<Role> result = new List<Role>();
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.Goalkeeper));
            result.AddRange(RoleCollection.Instance.GetRoles(RoleType.SweeperKeeper));

            return result;
        }

        public Position GetPosition(PositionType positionType)
        {
            if (positions.All(position => position.PositionType != positionType))
            {
                throw new ArgumentException($"Position {positionType} not found");
            }

            return positions.First(position => position.PositionType == positionType);
        }


    }
}
