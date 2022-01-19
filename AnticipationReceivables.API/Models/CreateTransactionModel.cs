using System;

namespace AnticipationReceivables.API.Models
{
    public class CreateTransactionModel
    {
        public int NSU { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime TransactionApprovedDate { get; set; }
        public DateTime TransactionDisapprovalDate { get; set; }
        public bool Anticipate { get; set; }
        public Enum AcquirerConfirmation { get; set; }
        public decimal GrossTransactionAmount { get; set; }
        public decimal TransactionNetAmount { get; set; }
        public decimal FixedFeeCharged { get; set; }
        public int NumberInstallments { get; set; }
        public string LastFourFigitsCard { get; set; }
    }
}
