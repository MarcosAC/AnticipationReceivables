using AnticipationReceivables.Core.Enums;
using System;
using System.Collections.Generic;

namespace AnticipationReceivables.Core.Entities
{
    public class Anticipation : BaseEntity
    {
        public Anticipation(DateTime solicitation, DateTime startAnalysis, DateTime finalizationAnalysis, decimal amountSolicitation, decimal amountAnticipation)
        {
            Solicitation = solicitation;
            StartAnalysis = startAnalysis;
            FinalizationAnalysis = finalizationAnalysis;
            AmountSolicitation = amountSolicitation;
            AmountAnticipation = amountAnticipation;

            Transactions = new List<Transaction>();
        }

        public DateTime Solicitation { get; set; }
        public DateTime StartAnalysis { get; set; }
        public DateTime FinalizationAnalysis { get; set; }
        public AnalysisResultEnum AnalysisResult { get; set; }
        public decimal AmountSolicitation { get; set; }
        public decimal AmountAnticipation { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
