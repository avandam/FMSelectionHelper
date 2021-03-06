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

            int firstAttributeIndex = header.ContainsKey("PA") ? 17 : 14;

            // Parse individual players
            lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] playerInformation = line.Split('|').ToList().Where(currentLine => currentLine != string.Empty).ToArray();
                string name = playerInformation[header["Name"]].Trim();
                int age = Convert.ToInt32(playerInformation[header["Age"]].Trim());
                string contractInfo = playerInformation[header["Expires"]].Trim();
                int contractEndYear = -1;
                if (contractInfo != "-")
                {
                    contractEndYear = Convert.ToInt32(contractInfo.Substring(contractInfo.Length - 4));
                }

                PlayerDetails playerDetails = ParsePlayerDetails(playerInformation, header);
                Dictionary<Attribute, int> attributes = ParseAttributes(playerInformation, header, firstAttributeIndex);
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
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.GK));
                return positions;
            }
            if (positionToParse == "ST (C)")
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.ST));
                return positions;
            }
            if (positionToParse == "DM")
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.DM));
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
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.AML));
            }

            if (side.Contains('C'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.AMC));
            }

            if (side.Contains('R'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.AMR));
            }

            return positions;
        }

        private List<Position> ParseMidfielders(string side)
        {
            List<Position> positions = new List<Position>();
            if (side.Contains('L'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.ML));
            }

            if (side.Contains('C'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.MC));
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.MCR));
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.MCL));
            }

            if (side.Contains('R'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.MR));
            }

            return positions;
        }

        private List<Position> ParseWingBacks(string side)
        {
            List<Position> positions = new List<Position>();
            if (side.Contains('L'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.WBL));
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.DL));
            }

            if (side.Contains('R'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.WBR));
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.DR));
            }

            return positions;
        }

        private List<Position> ParseDefenders(string side)
        {
            List<Position> positions = new List<Position>();
            if (side.Contains('L'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.DL));
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.WBL));
            }

            if (side.Contains('C'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.DC));
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.DCR));
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.DCL));
            }

            if (side.Contains('R'))
            {
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.DR));
                positions.Add(PositionCollection.Instance.GetPosition(PositionType.WBR));
            }

            return positions;
        }

        private Dictionary<Attribute, int> ParseAttributes(string[] playerInformation, Dictionary<string, int> header, int firstIndex)
        {
            Dictionary<Attribute, int> attributes = new Dictionary<Attribute, int>();
            for (int i = firstIndex; i < header.Count - 1; i++)
            {

                Attribute attribute = AttributeCollection.Instance.GetAttribute(header.ElementAt(i).Key);
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
            int squadNumber = playerInformation[header["No."]].Trim() == "-" ? -1 : Convert.ToInt32(playerInformation[header["No."]].Trim());
            string askingPrice = "Unknown";
            int currentAbility = -1;
            int potentialAbility = -1;

            try
            {
                askingPrice = playerInformation[header["AP"]].Trim();
                currentAbility = Convert.ToInt32(playerInformation[header["CA"]].Trim());
                potentialAbility = Convert.ToInt32(playerInformation[header["PA"]].Trim());
            }
            catch 
            {
                Console.WriteLine("Info not available");
            }
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