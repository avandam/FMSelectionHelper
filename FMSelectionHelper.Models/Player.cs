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

        public Player(string name, int age, int contractEndYear, PlayerDetails playerDetails, Dictionary<Attribute, int> attributes, List<Position> positions)
        {
            Name = name;
            Age = age;
            ContractEndYear = contractEndYear;
            PlayerDetails = playerDetails;
            this.attributes = attributes;
            this.positions = positions;
        }
    }
}