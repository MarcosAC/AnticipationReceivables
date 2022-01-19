using AnticipationReceivables.Core.Entities;
using AnticipationReceivables.Core.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnticipationReceivables.Infrastructure.Persistence.Repositories
{
    public class AnticipationRepository : IAnticipationRepository
    {
        private readonly AnticipationReceivablesDbContext _dbContext;
        private readonly string _connectionString;

        public AnticipationRepository(AnticipationReceivablesDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("AnticipationReceivablesCs");
        }

        public async Task AddAsync(Anticipation anticipation)
        {
            await _dbContext.Anticipations.AddAsync(anticipation);
            await SaveChangesAsync();
        }

        public async Task<List<Anticipation>> GetAllAsync()
        {
            return await _dbContext.Anticipations.ToListAsync();
        }

        public async Task<Anticipation> GetByIdAsync(int id)
        {
            return await _dbContext.Anticipations.SingleOrDefaultAsync(anticipation => anticipation.Id == id);
        }

        public async Task<List<Anticipation>> GetByStatus(string status)
        {
            return await _dbContext.Anticipations.SingleOrDefaultAsync(anticipation => anticipation.status == status); ;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task StartAsync(Anticipation anticipation)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "UPDATE Anticipations SET Status = @status, StartedAt = @startedat WHERE Id = @id";

                await sqlConnection.ExecuteAsync(script, new { status = anticipation.Status, startedat = anticipation.Started, anticipation.Id });
            }
        }
    }
}
