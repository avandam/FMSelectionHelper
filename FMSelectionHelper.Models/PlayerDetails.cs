namespace FMSelectionHelper.Models
{
    public class PlayerDetails
    {
        public FootSkill RightFoot { get; }
        public FootSkill LeftFoot { get; }
        public TransferStatus TransferStatus { get; }
        public TransferStatus LoanStatus { get; }
        public string AskingPrice { get; }
        public int SquadNumber { get; }
        public int CurrentAbility { get; }
        public int PotentialAbility { get; }

        public PlayerDetails(FootSkill rightFoot, FootSkill leftFoot, TransferStatus transferStatus, TransferStatus loanStatus, string askingPrice, int squadNumber, int currentAbility, int potentialAbility)
        {
            RightFoot = rightFoot;
            LeftFoot = leftFoot;
            TransferStatus = transferStatus;
            LoanStatus = loanStatus;
            AskingPrice = askingPrice;
            SquadNumber = squadNumber;
            CurrentAbility = currentAbility;
            PotentialAbility = potentialAbility;
        }
    }
}
