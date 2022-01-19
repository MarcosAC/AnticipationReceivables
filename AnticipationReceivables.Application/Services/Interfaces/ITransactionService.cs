using AnticipationReceivables.Application.InputModels;
using AnticipationReceivables.Application.ViewModels;
using System.Collections.Generic;

namespace AnticipationReceivables.Application.Services.Interfaces
{
    public interface ITransactionService
    {
        int Create(NewTransactionInputModel inputModel);
        TransactionViewModel GetById(int id);
        List<TransactionViewModel> GetAll();
    }
}
