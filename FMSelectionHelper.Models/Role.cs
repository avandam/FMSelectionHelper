using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMSelectionHelper.Infra;

namespace FMSelectionHelper.Models
{
    public  class Role
    {
        public string Name { get; }
        public string ShortName { get; }
        public List<Position> Positions { get; }
        public int Index { get; }
        public List<Attribute> KeyAttributes { get; }
        public List<Attribute> PreferableAttributes { get; }

        public Role(string name, string shortName, List<Position> positions, int index, List<Attribute> keyAttributes, List<Attribute> preferableAttributes)
        {
            Name = name;
            ShortName = shortName;
            Positions = positions;
            Index = index;
            KeyAttributes = keyAttributes;
            PreferableAttributes = preferableAttributes;
        }
    }
}
