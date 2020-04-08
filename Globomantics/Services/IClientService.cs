using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public interface IClientService
    {
        Task<IEnumerable<ClientModel>> GetAll();
        Task<ClientModel> GetById(int id);


        Task<UBOModel> GetStatistics(UBOModel model);
        Task AddCompanyUBO(ClientModel model);
        Task AddCompanyCEO(ClientModel model);
        Task Delete(ClientModel model);
        
    }
}