using System.Reflection.Metadata.Ecma335;
using FMSelectionHelper.FileHandler;
using FMSelectionHelper.Models;

namespace FMSelectionHelper.Business
{
    public class FormationService
    {
        public List<Formation> GetFormations()
        {
            List<Formation> formations = new List<Formation>();
            string[] formationLocations = Directory.GetFiles(Environment.CurrentDirectory, "*.for");
            foreach (string formationPath in formationLocations)
            {
                List<FormationPosition> formation = new List<FormationPosition>();

                try
                {
                    string[] formationLines = File.ReadAllLines(formationPath);
                    for (int i = 0; i < 11; i++)
                    {
                        string[] formationParts = formationLines[i].Split('|');
                        Position position = PositionCollection.Instance.GetPosition((PositionType) Enum.Parse(typeof(PositionType), formationParts[0]));
                        Role role = RoleCollection.Instance.GetRole((RoleType) Enum.Parse(typeof(RoleType), formationParts[1]), (Duty)Enum.Parse(typeof(Duty), formationParts[2]));
                        formation.Add(new FormationPosition(i, position, role));
                    }

                    formations.Add(new Formation(Path.GetFileNameWithoutExtension(formationPath), formation));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            if (formations.Count == 0)
            {
                formations.Add(GetDefaultFormation());
            }
            return formations;
        }

        public Formation GetDefaultFormation()
        {
            List<FormationPosition> selection = new List<FormationPosition>();
            selection.Add(new FormationPosition(0, PositionCollection.Instance.GetPosition(PositionType.GK), RoleCollection.Instance.GetRole(RoleType.SweeperKeeper, Duty.Defend)));
            selection.Add(new FormationPosition(1, PositionCollection.Instance.GetPosition(PositionType.DL), RoleCollection.Instance.GetRole(RoleType.WingBack, Duty.Support)));
            selection.Add(new FormationPosition(2, PositionCollection.Instance.GetPosition(PositionType.DCL), RoleCollection.Instance.GetRole(RoleType.CentralDefender, Duty.Defend)));
            selection.Add(new FormationPosition(3, PositionCollection.Instance.GetPosition(PositionType.DCR), RoleCollection.Instance.GetRole(RoleType.CentralDefender, Duty.Defend)));
            selection.Add(new FormationPosition(4, PositionCollection.Instance.GetPosition(PositionType.DR), RoleCollection.Instance.GetRole(RoleType.WingBack, Duty.Support)));
            selection.Add(new FormationPosition(5, PositionCollection.Instance.GetPosition(PositionType.MCL), RoleCollection.Instance.GetRole(RoleType.DeepLyingPlaymaker, Duty.Support)));
            selection.Add(new FormationPosition(6, PositionCollection.Instance.GetPosition(PositionType.MCR), RoleCollection.Instance.GetRole(RoleType.BoxToBoxMidfielder, Duty.Support)));
            selection.Add(new FormationPosition(7, PositionCollection.Instance.GetPosition(PositionType.AML), RoleCollection.Instance.GetRole(RoleType.InsideForward, Duty.Attack)));
            selection.Add(new FormationPosition(8, PositionCollection.Instance.GetPosition(PositionType.AMC), RoleCollection.Instance.GetRole(RoleType.ShadowStriker, Duty.Attack)));
            selection.Add(new FormationPosition(9, PositionCollection.Instance.GetPosition(PositionType.AMR), RoleCollection.Instance.GetRole(RoleType.InsideForward, Duty.Support)));
            selection.Add(new FormationPosition(10, PositionCollection.Instance.GetPosition(PositionType.ST), RoleCollection.Instance.GetRole(RoleType.AdvancedForward, Duty.Attack)));
            return new Formation("Default", selection);
        }
    }
}
