using System.Collections.ObjectModel;

// ReSharper disable InconsistentNaming

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

        public List<RoleScore> RoleScores { get; }

        public double GlobalScore { get; private set; }

        public Player(string name, int age, int contractEndYear, PlayerDetails playerDetails, Dictionary<Attribute, int> attributes, List<Position> positions)
        {
            Name = name;
            Age = age;
            ContractEndYear = contractEndYear;
            PlayerDetails = playerDetails;
            this.attributes = attributes;
            this.positions = positions;
            RoleScores = new List<RoleScore>();
        }

        public double GetRoleScore(int index)
        {
            return RoleScores.First(roleScore => roleScore.Position.Index == index).Score;
        }

        public void ComputeScores(Formation formation)
        {
            RoleScores.Clear();
            foreach (var position in formation.Selection)
            {
                if (CanPlayAtPosition(position.Position.PositionType))
                {
                    RoleScores.Add(new RoleScore(position, attributes));
                }
                else
                {
                    RoleScores.Add(new RoleScore(position));
                }
            }

            GlobalScore = Math.Round(attributes.Average(attribute => attribute.Value), 2);
        }

        private bool CanPlayAtPosition(PositionType positionType)
        {
            return positions.Any(position => position.PositionType == positionType);
        }
    }
}