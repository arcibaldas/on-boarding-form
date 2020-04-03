using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public class CompanyService : ICompanyService
    {

        private readonly List<CompanyModel> companies = new List<CompanyModel>();

        public CompanyService () {
            companies.Add(new CompanyModel
            {
                Email="skura@one.lt",

                CompanyName = "UAB BEKENTAS",

                TradingName = "Swedbank",

                LegalStatus = "Active",

                CountryOfRegistration = "Lithuania",

                LegalAddress = "vaiku 15-24",

                PhysicalAddress = "Jogailos 9A",

                RegistrationCode = 911,

                IncorporationDate = new DateTime(2017, 8, 12),

                CompanyPhoneNumber = "+3706794975",

                CompanyEmail = "valera@opapa.lt",

                Activities = "Freelancing",

                Services = true,

                Regions = "Africa",

                Partners = "Fc vytis",

                LastYearTurnover = 12584664,


                NextYearTurnover = 21234587,

                Structure = "wavy",

                License = false,
                Website = "one.lt",
                Expected = "maybe"
            });
    }
        public Task AddCompanyRepresentative(CompanyModel model)
        {
            model.Id = companies.Max(c => c.Id) + 1;
            model.RepresentativeId = companies.Max(c => c.RepresentativeId) + 1;
            model.CompanyId = companies.Max(c => c.CompanyId) + 1;
            companies.Add(model);
            return Task.CompletedTask;
        }

        public Task AddCompanyCEO(CompanyModel model)
        {
            model.Id = companies.Max(c => c.Id) + 1;
            model.CeoId = companies.Max(c => c.CeoId) + 1;
            model.CompanyId = companies.Max(c => c.CompanyId) + 1;
            companies.Add(model);
            return Task.CompletedTask;
        }

        public Task AddCompanyUBO(CompanyModel model)
        {
            model.Id = companies.Max(c => c.Id) + 1;
            model.UboId = companies.Max(c => c.UboId) + 1;
            model.CompanyId = companies.Max(c => c.CompanyId) + 1;
            companies.Add(model);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<CompanyModel>> GetAll()
        {
            return Task.Run(() => companies.AsEnumerable());
        }

        public Task<CompanyModel> GetById(int id)
        {
            return Task.Run(() => companies.First(c => c.Id == id));
        }

        public Task<CompanyModel> VerifyEmail(string email)
        {
            return Task.Run(() =>companies.First(c=>c.Email==email));
        }
    }
}
