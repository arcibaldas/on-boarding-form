using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public interface IClientService
    {
        Task<IEnumerable<ClientModel>> GetAll(int id);
        Task<ClientModel> GetById(int id);

       
        //Task<StatisticsModel> GetStatistics();
        Task Add(ClientModel model);
        Task Delete(ClientModel model);
        
    }
}