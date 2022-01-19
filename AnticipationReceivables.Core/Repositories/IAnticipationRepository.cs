using AnticipationReceivables.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnticipationReceivables.Core.Repositories
{
    public interface IAnticipationRepository
    {        
        Task<List<Anticipation>> GetAllAsync();
        Task<List<Anticipation>> GetByStatus(string status);
        Task<Anticipation> GetByIdAsync(int id);
        Task AddAsync(Anticipation anticipation);
        Task StartAsync(Anticipation anticipation);
        //Task AddInstallmentAsync(Installment installment);
        Task SaveChangesAsync();
    }
}
