using FMSelectionHelper.Models;
using Attribute = FMSelectionHelper.Models.Attribute;

namespace FMSelectionHelper.FileHandler
{
    public class SaveGameReader
    {
        public List<Player> ParseFile(string path)
        {
            List<Player> players = new List<Player>();

            List<string> lines = File.ReadAllLines(path).ToList();
            lines = lines.Where(line => line != string.Empty && 
                                              !line.Contains("---------"))
                         .ToList();

            // Parse header
            string[] headerLineParts = lines[0].Split('|').ToList().Where(headerPart => headerPart != string.Empty).ToArray();
            Dictionary<string, int> header = new Dictionary<string, int>();
            for (int i = 0; i < headerLineParts.Length; i++)
            {
                if (headerLineParts[i] != string.Empty)
                {
                    header.Add(headerLineParts[i].Trim(), i);
                }
            }

            // Parse individual players
            lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] playerInformation = line.Split('|').ToList().Where(currentLine => currentLine != string.Empty).ToArray();
                string name = playerInformation[header["Name"]].Trim();
                int age = Convert.ToInt32(playerInformation[header["Age"]].Trim());
                int contractEndYear = Convert.ToInt32(playerInformation[header["Expires"]].Trim().Substring(playerInformation[header["Expires"]].Trim().Length - 4));

                PlayerDetails playerDetails = ParsePlayerDetails(playerInformation, header);
                Dictionary<Attribute, int> attributes = ParseAttributes(playerInformation, header);
                List<Position> positions = ParsePositions(playerInformation[header["Position"]].Trim());

                Player player = new Player(name, age, contractEndYear, playerDetails, attributes, positions);
                players.Add(player);
            }

            return players;

        }

        public List<Position> ParsePositions(string positionsRaw)
        {
            List<Position> positions = new List<Position>();

            if (positionsRaw.Contains(','))
            {
                string[] positionLines = positionsRaw.Split(',');
                foreach (string line in positionLines)
                {
                    positions.AddRange(ParseSinglePosition(line.Trim()));
                }
            }
            else
            {
                positions.AddRange(ParseSinglePosition(positionsRaw.Trim()));
            }

            return positions;
        }

        private List<Position> ParseSinglePosition(string positionToParse)
        {
            List<Position> positions = new List<Position>();

            if (positionToParse == "GK")
            {
                positions.Add(Position.GK);
                return positions;
            }
            if (positionToParse == "ST (C)")
            {
                positions.Add(Position.ST);
                return positions;
            }
            if (positionToParse == "DM")
            {
                positions.Add(Position.DM);
                return positions;
            }

            string position = positionToParse.Split(' ')[0];
            string side = positionToParse.Split(' ')[1];

            if (position.Contains('/'))
            {
                string[] positionsRaw = position.Split('/');
                foreach (string positionRaw in positionsRaw)
                {
                    positions.AddRange(ParseComplexPosition(positionRaw, side));
                }

                return positions;
            }
            
            positions.AddRange(ParseComplexPosition(position, side));

            return positions;
        }

        private List<Position> ParseComplexPosition(string positionRaw, string side)
        {
            if (positionRaw == "D")
            {
                return ParseDefenders(side);
            }
            else if (positionRaw == "WB")
            {
                return ParseWingBacks(side);
            }
            else if (positionRaw == "M")
            {
                return ParseMidfielders(side);
            }
            else if (positionRaw == "AM")
            {
                return ParseAttackingMidfielders(side);

            }
            else 
            {
                throw new ArgumentException("position could not be parsed");
            }
        }

        private List<Position> ParseAttackingMidfielders(string side)
        {
            List<Position> positions = new List<Position>();
            if (side.Contains('L'))
            {
                positions.Add(Position.AML);
            }

            if (side.Contains('C'))
            {
                positions.Add(Position.AMC);
            }

            if (side.Contains('R'))
            {
                positions.Add(Position.AMR);
            }

            return positions;
        }

        private List<Position> ParseMidfielders(string side)
        {
            List<Position> positions = new List<Position>();
            if (side.Contains('L'))
            {
                positions.Add(Position.ML);
            }

            if (side.Contains('C'))
            {
                positions.Add(Position.MC);
            }

            if (side.Contains('R'))
            {
                positions.Add(Position.MR);
            }

            return positions;
        }

        private List<Position> ParseWingBacks(string side)
        {
            List<Position> positions = new List<Position>();
            if (side.Contains('L'))
            {
                positions.Add(Position.WBL);
            }

            if (side.Contains('R'))
            {
                positions.Add(Position.WBR);
            }

            return positions;
        }

        private List<Position> ParseDefenders(string side)
        {
            List<Position> positions = new List<Position>();
            if (side.Contains('L'))
            {
                positions.Add(Position.DL);
            }

            if (side.Contains('C'))
            {
                positions.Add(Position.DC);
            }

            if (side.Contains('R'))
            {
                positions.Add(Position.DR);
            }

            return positions;
        }

        private Dictionary<Attribute, int> ParseAttributes(string[] playerInformation, Dictionary<string, int> header)
        {
            Dictionary<Attribute, int> attributes = new Dictionary<Attribute, int>();
            // Fixed: index 17 - 76
            for (int i = 17; i <= 76; i++)
            {

                Attribute attribute = Attributes.Instance.GetAttribute(header.ElementAt(i).Key);
                int attributeValue = Convert.ToInt32(playerInformation[i]);
                attributes.Add(attribute, attributeValue);
            }

            return attributes;
        }

        private PlayerDetails ParsePlayerDetails(string[] playerInformation, Dictionary<string, int> header)
        {
            FootSkill rightFoot = ParseFootSkill(playerInformation[header["Right Foot"]].Trim().ToLower());
            FootSkill leftFoot = ParseFootSkill(playerInformation[header["Left Foot"]].Trim().ToLower());
            TransferStatus transferStatus = ParseTransferStatus(playerInformation[header["Transfer Status"]].Trim().ToLower());
            TransferStatus loanStatus = ParseTransferStatus(playerInformation[header["Loan Status"]].Trim().ToLower());
            string askingPrice = playerInformation[header["AP"]].Trim();
            int squadNumber = playerInformation[header["No."]].Trim() == "-" ? -1 : Convert.ToInt32(playerInformation[header["No."]].Trim());
            int currentAbility = Convert.ToInt32(playerInformation[header["CA"]].Trim());
            int potentialAbility = Convert.ToInt32(playerInformation[header["PA"]].Trim());
            return new PlayerDetails(rightFoot, leftFoot, transferStatus, loanStatus, askingPrice, squadNumber, currentAbility, potentialAbility);
        }

        private FootSkill ParseFootSkill(string value)
        {
            switch (value)
            {
                case "weak":
                    return FootSkill.Weak;
                case "reasonable":
                    return FootSkill.Reasonable;
                case "fairly strong":
                    return FootSkill.FairlyStrong;
                case "very strong":
                    return FootSkill.VeryStrong;
                default:
                    return FootSkill.Unknown;
            }
        }

        private TransferStatus ParseTransferStatus(string value)
        {
            switch (value)
            {
                case "not set":
                    return TransferStatus.NotSet;
                case "listed":
                    return TransferStatus.Listed;
                case "unavailable":
                    return TransferStatus.Unavailable;
                default:
                    return TransferStatus.Unknown;
            }
        }
    }
}