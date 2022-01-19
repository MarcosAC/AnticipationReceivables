using System;

namespace AnticipationReceivables.Application.InputModels
{
    public class NewTransactionInputModel
    {
        public int NSU { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal GrossTransactionAmount { get; set; }
        public decimal TransactionNetAmount { get; set; }
        public decimal FixedFeeCharged { get; set; }
        public int NumberInstallments { get; set; }
        public string LastFourFigitsCard { get; set; }
    }
}
