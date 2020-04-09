using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyModel>> GetAll();
        Task<CompanyModel> GetById(int id);
        Task AddCompanyRepresentative(CompanyModel model);
 
        Task<CompanyModel> VerifyEmail(string email);
    }
}
