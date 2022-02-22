namespace FMSelectionHelper.Models
{
    public class Formation
    {
        private readonly List<FormationPosition> selection;
        public IReadOnlyCollection<FormationPosition> Selection => selection.AsReadOnly();
        public string Name { get; }

        public Formation(string name, List<FormationPosition> formation)
        {
            Name = name;
            selection = formation;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
