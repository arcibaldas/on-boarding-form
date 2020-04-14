using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public interface IClientService
    {
        Task<IEnumerable<ClientModel>> GetAll();
        Task<ClientModel> GetById(int id);

        Task AddCompanyCEO(ClientModel model, int newId);
        Task AddCompanyUBO(ClientModel model, int newId);
        Task<ClientModel> Delete(string personal);


    }
}