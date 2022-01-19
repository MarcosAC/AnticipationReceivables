using AnticipationReceivables.Core.Entities;
using AnticipationReceivables.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnticipationReceivables.Infrastructure.Persistence.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AnticipationReceivablesDbContext _dbContext;
        private readonly string _connectionString;

        public TransactionRepository(AnticipationReceivablesDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("AnticipationReceivablesCs");
        }

        public async Task AddAsync(Transaction transaction)
        {
            await _dbContext.Transactions.AddAsync(transaction);
            await SaveChangesAsync();
        }

        public Task AddInstallmentAsync(Installment installment)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Transaction>> GetAllAsync()
        {
            return await _dbContext.Transactions.ToListAsync();
        }

        public async Task<Transaction> GetByIdAsync(int id)
        {
            return await _dbContext.Transactions.SingleOrDefaultAsync(transaction => transaction.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
