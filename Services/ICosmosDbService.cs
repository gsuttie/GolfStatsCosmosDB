using GolfStatsCosmosDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfStatsCosmosDB.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Score>> GetScoresAsync(string query);
        Task<Score> GetScoreAsync(string id);
        Task AddScoreAsync(Score score);
        Task UpdateScoreAsync(string id, Score score);
        Task DeleteScoreAsync(string id);
    }
}
