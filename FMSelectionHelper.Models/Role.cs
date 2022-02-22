namespace FMSelectionHelper.Models
{

    public class Role
    {
        public RoleType RoleType { get; }
        public Duty Duty { get; }
        private readonly List<Attribute> keyAttributes;
        public IReadOnlyCollection<Attribute> KeyAttributes => keyAttributes.AsReadOnly();
        private readonly List<Attribute> preferableAttributes;
        public IReadOnlyCollection<Attribute> PreferableAttributes => preferableAttributes.AsReadOnly();

        public Role(RoleType roleType, Duty duty, List<Attribute> keyAttributes, List<Attribute> preferableAttributes)
        {
            RoleType = roleType;
            Duty = duty;
            this.keyAttributes = keyAttributes;
            this.preferableAttributes = preferableAttributes;
        }

        public override string ToString()
        {
            return RoleType.ToDescriptionString() + " " + Duty.ToDescriptionString();
        }
    }
}
