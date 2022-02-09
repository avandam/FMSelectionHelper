using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSelectionHelper.Models
{
    public class Attribute
    {
        public string Abbreviation { get; }
        public string Name { get; }
        public bool IsHidden { get; }

        public Attribute(string abbreviation, string name, bool isHidden)
        {
            Abbreviation = abbreviation;
            Name = name;
            IsHidden = isHidden;
        }
    }
}
