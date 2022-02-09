using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMSelectionHelper.Infra;

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

        public PlayerDetails(FootSkill rightFoot, FootSkill leftFoot, TransferStatus transferStatus, TransferStatus loanStatus, string askingPrice, int squadNumber)
        {
            RightFoot = rightFoot;
            LeftFoot = leftFoot;
            TransferStatus = transferStatus;
            LoanStatus = loanStatus;
            AskingPrice = askingPrice;
            SquadNumber = squadNumber;
        }
    }
}
