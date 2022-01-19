using AnticipationReceivables.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnticipationReceivables.Core.Repositories
{
    public interface ITransactionRepository
    {
        Task<List<Transaction>> GetAllAsync();
        //Task<Transaction> GetByStatus(string query);
        Task<Transaction> GetByIdAsync(int id);        
        Task AddAsync(Transaction transaction);
        Task AddInstallmentAsync(Installment installment);
        Task SaveChangesAsync();
    }
}
