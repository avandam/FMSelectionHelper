using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FMSelectionHelper.Infra;

namespace FMSelectionHelper.Models
{
    public sealed class Roles
    {
        private static readonly Roles instance = new Roles();
        public static Roles Instance => instance;

        private List<Role> roles = new List<Role>();

        static Roles()
        {

        }

        private Roles()
        {
            CreateRoles();
        }

        private void CreateRoles()
        {
            CreateGoalkeeperRole();
            CreateWingBackRole(Position.WBL, "DL", 2);
            CreateDefenderRole();
            CreateWingBackRole(Position.WBR, "DR", 4);
            CreateDeepLayingPlaymakerRole();
            CreateBoxToBoxMidfielderRole();
            CreateInsideForwardAttackRole();
            CreateShadowStrikerRole();
            CreateInsideForwardSupRole();
            CreateAdvancedForwardRole();

            roles = roles.OrderBy(role => role.Index).ToList();
        }

        private void CreateAdvancedForwardRole()
        {
            List<Position> positions = new List<Position>();
            positions.Add(Position.ST);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Dri"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Fin"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Fir"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tec"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Cmp"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("OtB"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Acc"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pas"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Dec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Wor"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Agi"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Bal"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pac"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Sta"));


            roles.Add(new Role("Advance Forward (Attacking)", "ST", positions, 10, keyAttributes, preferableAttributes));
        }

        private void CreateInsideForwardSupRole()
        {
            List<Position> positions = new List<Position>();
            positions.Add(Position.MR);
            positions.Add(Position.AMR);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Dri"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Fir"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Pas"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tec"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("OtB"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Acc"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Agi"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Bal"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Fin")); 
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Lon"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Cmp"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Fla"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Vis"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pac"));

            roles.Add(new Role("Inside Forward (Support)", "AMR", positions, 9, keyAttributes, preferableAttributes));
        }

        private void CreateShadowStrikerRole()
        {
            List<Position> positions = new List<Position>();
            positions.Add(Position.MC);
            positions.Add(Position.AMC);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Dri"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Fin"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Fir"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Cmp"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("OtB"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Acc"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pas"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Tec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Cnt"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Dec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Wor"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Agi"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Bal"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pac"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Sta"));

            roles.Add(new Role("Shadow Striker (Attacking)", "AMC", positions, 8, keyAttributes, preferableAttributes));
        }

        private void CreateInsideForwardAttackRole()
        {
            List<Position> positions = new List<Position>();
            positions.Add(Position.ML);
            positions.Add(Position.AML);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Dri"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Fin"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Fir"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tec"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Acc"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Agi"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Bal"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Lon"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pas"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Cmp"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Fla"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pac"));

            roles.Add(new Role("Inside Forward (Attacking)", "AML", positions, 7, keyAttributes, preferableAttributes));
        }

        private void CreateBoxToBoxMidfielderRole()
        {
            List<Position> positions = new List<Position>();
            positions.Add(Position.DM);
            positions.Add(Position.MC);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Pas"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tck"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("OtB"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tea"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Wor"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Sta"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Dri"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Fin"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Fir"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Lon"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Tec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Agg"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Cmp"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Dec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pos"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Acc"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Bal"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pac"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Str"));

            roles.Add(new Role("Box to Box Midfielder (Support)", "BBM", positions, 6, keyAttributes, preferableAttributes));
        }

        private void CreateDeepLayingPlaymakerRole()
        {
            List<Position> positions = new List<Position>();
            positions.Add(Position.DM);
            positions.Add(Position.MC);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Fir"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Pas"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tec"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Cmp"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Dec"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tea"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Vis"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("OtB"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pos"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Bal"));

            roles.Add(new Role("Deep Laying Playmaker (Support)", "DLP", positions, 5, keyAttributes, preferableAttributes));
        }

        private void CreateDefenderRole()
        {
            List<Position> positions = new List<Position>();
            positions.Add(Position.DC);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Hea"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Mar"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tck"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Pos"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Jum"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Str"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Agg"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Bra"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Cmp"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Cnt"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Dec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pac"));

            roles.Add(new Role("Central Defender (Defend)", "DC", positions, 3, keyAttributes, preferableAttributes));
        }

        private void CreateWingBackRole(Position position, string name, int index)
        {
            List<Position> positions = new List<Position>();
            positions.Add(position);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Cro"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Dri"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Mar"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tck"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("OtB"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Tea"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Wor"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Acc"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Sta"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Fir"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pas"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Tec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Cnt"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Dec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pos"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Agi"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pac"));

            roles.Add(new Role("Wing-Back (Support)", name, positions, index, keyAttributes, preferableAttributes));
        }

        private void CreateGoalkeeperRole()
        {
            List<Position> positions = new List<Position>();
            positions.Add(Position.GK);

            List<Attribute> keyAttributes = new List<Attribute>();
            keyAttributes.Add(Attributes.Instance.GetAttribute("Cmd"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Kic"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("1v1"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Ref"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("TRO"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Ant"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Cmp"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Cnt"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Pos"));
            keyAttributes.Add(Attributes.Instance.GetAttribute("Agi"));

            List<Attribute> preferableAttributes = new List<Attribute>();
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Aer"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Com"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Fir"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Han"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Pas"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Thr"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Dec"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Vis"));
            preferableAttributes.Add(Attributes.Instance.GetAttribute("Acc"));

            roles.Add(new Role("Sweeper Keeper (Defend)", "GK", positions, 1, keyAttributes, preferableAttributes));

            
        }

        public IReadOnlyCollection<Role> GetAllRoles()
        {
            return roles.AsReadOnly();
        }
    }
}
