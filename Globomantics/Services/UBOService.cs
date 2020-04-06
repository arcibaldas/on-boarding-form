using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.Services
{
    public class UBOService : IUBOService
    {

        private readonly List<CompanyUBO> companies = new List<CompanyUBO>();

        public Task AddCompanyUBO(CompanyUBO model)
        {
            
            model.CompanyId = companies.Max(c => c.CompanyId) + 1;
            companies.Add(model);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<CompanyUBO>> GetAll()
        {

            return Task.Run(() => companies.AsEnumerable());
        }

        public Task<CompanyUBO> GetById(int id)
        {
            return Task.Run(() => companies.First(c => c.CompanyId == id));
        }

    }
}
