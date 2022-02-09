using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSelectionHelper.Models
{
    // Create Singleton
    public sealed class Attributes
    {
        private static readonly Attributes instance = new Attributes();

        static Attributes()
        {

        }

        private Attributes()
        {
            attributes = new List<Attribute>();
            FillAttributes();
        }

        public static Attributes Instance => instance;

        private List<Attribute> attributes;

        private void FillAttributes()
        {
            attributes.Add(new Attribute("Wor", "Work rate", false));
            attributes.Add(new Attribute("Vis", "Vision", false));
            attributes.Add(new Attribute("Thr", "Throwing", false));
            attributes.Add(new Attribute("Tec", "Technique", false));
            attributes.Add(new Attribute("Tea", "Teamwork", false));
            attributes.Add(new Attribute("Tck", "Tackling", false));
            attributes.Add(new Attribute("Str", "Strength", false));
            attributes.Add(new Attribute("Sta", "Stamina", false));
            attributes.Add(new Attribute("TRO", "Rushing Out (Tendency)", false));
            attributes.Add(new Attribute("Ref", "Reflexes", false));
            attributes.Add(new Attribute("Pun", "Punching (Tendency)", false));
            attributes.Add(new Attribute("Pos", "Positioning", false));
            attributes.Add(new Attribute("Pen", "Penalty Taking", false));
            attributes.Add(new Attribute("Pas", "Passing", false));
            attributes.Add(new Attribute("Pac", "Pace", false));
            attributes.Add(new Attribute("1v1", "One on Ones", false));
            attributes.Add(new Attribute("OtB", "Off the Ball", false));
            attributes.Add(new Attribute("Nat", "Natural Fitness", false));
            attributes.Add(new Attribute("Mar", "Marking", false));
            attributes.Add(new Attribute("L Th", "Long Throws", false));
            attributes.Add(new Attribute("Lon", "Long Shots", false));
            attributes.Add(new Attribute("Ldr", "Leadership", false));
            attributes.Add(new Attribute("Kic", "Kicking", false));
            attributes.Add(new Attribute("Jum", "Jumping", false));
            attributes.Add(new Attribute("Hea", "Heading", false));
            attributes.Add(new Attribute("Han", "Handling", false));
            attributes.Add(new Attribute("Fre", "Free Kicks", false));
            attributes.Add(new Attribute("Fla", "Flair", false));
            attributes.Add(new Attribute("Fir", "First Touch", false));
            attributes.Add(new Attribute("Fin", "Finishing", false));
            attributes.Add(new Attribute("Ecc", "Eccentricity", false));
            attributes.Add(new Attribute("Dri", "Dribbling", false));
            attributes.Add(new Attribute("Det", "Determination", false));
            attributes.Add(new Attribute("Dec", "Decisions", false));
            attributes.Add(new Attribute("Cro", "Crossing", false));
            attributes.Add(new Attribute("Cor", "Corners", false));
            attributes.Add(new Attribute("Cnt", "Concentration", false));
            attributes.Add(new Attribute("Cmp", "Composure", false));
            attributes.Add(new Attribute("Com", "Communication", false));
            attributes.Add(new Attribute("Cmd", "Command of Area", false));
            attributes.Add(new Attribute("Bra", "Bravery", false));
            attributes.Add(new Attribute("Bal", "Balance", false));
            attributes.Add(new Attribute("Ant", "Anticipation", false));
            attributes.Add(new Attribute("Agi", "Agility", false));
            attributes.Add(new Attribute("Agg", "Aggression", false));
            attributes.Add(new Attribute("Aer", "Aerial Reach", false));
            attributes.Add(new Attribute("Acc", "Acceleration", false));
            attributes.Add(new Attribute("Vers", "Versatility", true));
            attributes.Add(new Attribute("Temp", "Temperament", true));
            attributes.Add(new Attribute("Spor", "Sportmanship", true));
            attributes.Add(new Attribute("Prof", "Professionalism", true));
            attributes.Add(new Attribute("Pres", "Pressure", true));
            attributes.Add(new Attribute("Loy", "Loyalty", true));
            attributes.Add(new Attribute("Inj Pr", "Injury Proneness", true));
            attributes.Add(new Attribute("Imp M", "Important Matches", true));
            attributes.Add(new Attribute("Dirt", "Dirtiness", true));
            attributes.Add(new Attribute("Cont", "Controversy", true));
            attributes.Add(new Attribute("Cons", "Consistency", true));
            attributes.Add(new Attribute("Ada", "Adaptability", true));
            attributes.Add(new Attribute("Amb", "Ambition", true));
        }

        public Attribute GetAttribute(string abbreviation)
        {
            if (attributes.All(attribute => attribute.Abbreviation != abbreviation))
            {
                throw new ArgumentException($"Attribute {abbreviation} not found");
            }

            return attributes.First(attribute => attribute.Abbreviation == abbreviation);
        }


    }
}
