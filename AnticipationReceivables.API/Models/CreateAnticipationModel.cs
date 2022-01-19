using System;

namespace AnticipationReceivables.API.Models
{
    public class CreateAnticipationModel
    {
        public DateTime Solicitation { get; set; }
        public DateTime StartAnalysis { get; set; }
        public DateTime FinalizationAnalysis { get; set; }
        public decimal AmountSolicitation { get; set; }
        public decimal AmountAnticipation { get; set; }
    }
}
