namespace FMSelectionHelper.Models
{
    public class RoleScore
    {
        public string Name { get; }
        public Role Role { get; }
        private double keyScore;
        private double preferableScore;
        public double Score { get; private set; }

        public RoleScore(Role role, IReadOnlyDictionary<Attribute, int> playerAttributes)
        {
            Name = role.ShortName;
            Role = role;
            ComputeScore(playerAttributes);
        }

        public RoleScore(Role role)
        {
            Name = role.ShortName;
            Role = role;
            Score = double.NaN;
        }

        public void ComputeScore(IReadOnlyDictionary<Attribute, int> playerAttributes)
        {
            keyScore = 0.0;
            int nrOfKeyAttributes = Role.KeyAttributes.Count;
            foreach (var attribute in Role.KeyAttributes)
            {
                keyScore += playerAttributes.First(a => a.Key.Abbreviation == attribute.Abbreviation).Value;
            }

            keyScore /= nrOfKeyAttributes;

            preferableScore = 0.0;
            int nrOfPreferableAttributes = Role.PreferableAttributes.Count;
            foreach (var attribute in Role.PreferableAttributes)
            {
                preferableScore += playerAttributes.First(a => a.Key.Abbreviation == attribute.Abbreviation).Value;
            }

            preferableScore /= nrOfPreferableAttributes;

            Score = Math.Round((keyScore * 2 + preferableScore) / 3, 2);
        }
    }
}
