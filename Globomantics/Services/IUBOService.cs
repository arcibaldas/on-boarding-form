using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public interface IUBOService
    {
        Task<IEnumerable<CompanyUBO>> GetAll();
        Task<CompanyUBO> GetById(int id);
        Task AddCompanyUBO(CompanyUBO model);
    }
}
