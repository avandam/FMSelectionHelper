using System.Collections.ObjectModel;
using FMSelectionHelper.Infra;

namespace FMSelectionHelper.Models
{
    public class Player
    {
        public string Name { get; }
        public int Age { get; }
        public int ContractEndYear { get; }
        public PlayerDetails PlayerDetails { get; }

        private readonly Dictionary<Attribute, int> attributes;
        public IReadOnlyDictionary<Attribute, int> Attributes => new ReadOnlyDictionary<Attribute, int>(attributes);
        private readonly List<Position> positions;
        public IReadOnlyCollection<Position> Positions => positions.AsReadOnly();

        public List<RoleScore> RoleScores = new List<RoleScore>();

        public double GkScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "GK").Score; }
        }

        public double DLScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "DL").Score; }
        }

        public double DCScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "DC").Score; }
        }

        public double DRScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "DR").Score; }
        }

        public double DLPScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "DLP").Score; }
        }

        public double BBMScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "BBM").Score; }
        }

        public double AMLScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "AML").Score; }
        }

        public double AMCScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "AMC").Score; }
        }

        public double AMRScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "AMR").Score; }
        }

        public double STScore
        {
            get { return RoleScores.First(roleScore => roleScore.Name == "ST").Score; }
        }


        public Player(string name, int age, int contractEndYear, PlayerDetails playerDetails, Dictionary<Attribute, int> attributes, List<Position> positions)
        {
            Name = name;
            Age = age;
            ContractEndYear = contractEndYear;
            PlayerDetails = playerDetails;
            this.attributes = attributes;
            this.positions = positions;
        }

        public void ComputeScores()
        {
            foreach (Role role in Roles.Instance.GetAllRoles())
            {
                if (positions.Intersect(role.Positions).Any())
                {
                    RoleScores.Add(new RoleScore(role, Attributes));
                }
                else
                {
                    RoleScores.Add(new RoleScore(role));
                }
            }
        }
    }
}