using System;

namespace AnticipationReceivables.Core.Entities
{
    public class Transaction : BaseEntity
    {
        public Transaction(int nsu,
                           DateTime transactionDate,
                           decimal grossTransactionAmount,
                           decimal transactionNetAmount,
                           decimal fixedFeeCharged,
                           int numberInstallments,
                           string lastFourFigitsCard)
        {
            NSU = nsu;
            TransactionDate = transactionDate;
            GrossTransactionAmount = grossTransactionAmount;
            TransactionNetAmount = transactionNetAmount;
            FixedFeeCharged = fixedFeeCharged;
            NumberInstallments = numberInstallments;
            LastFourFigitsCard = lastFourFigitsCard;
        }

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
