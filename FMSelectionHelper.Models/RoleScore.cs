namespace FMSelectionHelper.Models
{
    public class RoleScore
    {
        public FormationPosition Position { get; }
        private double keyScore;
        private double preferableScore;
        public double Score { get; private set; }

        public RoleScore(FormationPosition position, IReadOnlyDictionary<Attribute, int> playerAttributes)
        {
            Position = position;
            ComputeScore(playerAttributes);
        }

        public RoleScore(FormationPosition position)
        {
            Position = position;
            Score = double.NaN;
        }

        public void ComputeScore(IReadOnlyDictionary<Attribute, int> playerAttributes)
        {
            keyScore = 0.0;
            int nrOfKeyAttributes = Position.Role.KeyAttributes.Count;
            foreach (var attribute in Position.Role.KeyAttributes)
            {
                keyScore += playerAttributes.First(a => a.Key.Abbreviation == attribute.Abbreviation).Value;
            }

            keyScore /= nrOfKeyAttributes;

            preferableScore = 0.0;
            int nrOfPreferableAttributes = Position.Role.PreferableAttributes.Count;
            foreach (var attribute in Position.Role.PreferableAttributes)
            {
                preferableScore += playerAttributes.First(a => a.Key.Abbreviation == attribute.Abbreviation).Value;
            }

            preferableScore /= nrOfPreferableAttributes;

            Score = Math.Round((keyScore * 2 + preferableScore) / 3, 2);
        }
    }
}
