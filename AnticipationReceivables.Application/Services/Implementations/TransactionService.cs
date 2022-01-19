using AnticipationReceivables.Application.InputModels;
using AnticipationReceivables.Application.Services.Interfaces;
using AnticipationReceivables.Application.ViewModels;
using AnticipationReceivables.Core.Entities;
using AnticipationReceivables.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace AnticipationReceivables.Application.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        private readonly AnticipationReceivablesDbContext _dbContext;

        public TransactionService(AnticipationReceivablesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewTransactionInputModel inputModel)
        {
            var transaction = new Transaction(
                inputModel.NSU,
                inputModel.TransactionDate,
                inputModel.GrossTransactionAmount,
                inputModel.TransactionNetAmount,
                inputModel.FixedFeeCharged,
                inputModel.NumberInstallments,
                inputModel.LastFourFigitsCard);

            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();

            return transaction.Id;
        }

        public List<TransactionViewModel> GetAll()
        {
            var transactions = _dbContext.Transactions;

            var transactionsViewModel = transactions
                .Select(transaction => new TransactionViewModel(transaction.Id,
                                                                transaction.NSU,
                                                                transaction.TransactionDate,
                                                                transaction.GrossTransactionAmount,
                                                                transaction.TransactionNetAmount,
                                                                transaction.FixedFeeCharged,
                                                                transaction.NumberInstallments,
                                                                transaction.LastFourFigitsCard)).ToList();

            return transactionsViewModel;
        }

        public TransactionViewModel GetById(int id)
        {
            var transaction = _dbContext.Transactions.SingleOrDefault(transaction => transaction.Id == id);

            if (transaction == null) return null;

            var transactionsViewModel = new TransactionViewModel(transaction.Id,
                                                                   transaction.NSU,
                                                                   transaction.TransactionDate,
                                                                   transaction.GrossTransactionAmount,
                                                                   transaction.TransactionNetAmount,
                                                                   transaction.FixedFeeCharged,
                                                                   transaction.NumberInstallments,
                                                                   transaction.LastFourFigitsCard);

            return transactionsViewModel;
        }
    }
}
