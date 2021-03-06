﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public class ClientService: IClientService
    {
        private readonly List<ClientModel> clients = new List<ClientModel>();
        


        public ClientService()
        {
            clients.Add(new ClientModel { Id = 1, Name = "Artur!", Surname="Skuratovič", Email="skura@one.lt", PhoneNumber="+37067949473", Citizenship = "Russian", BirthDate = new DateTime(2017, 8, 12), Address = "Vaiku" ,CountryOfResidence="Lithuania",BasisfOfRepresentation= "Occupation or power of attorney" });
            clients.Add(new ClientModel { Id = 2, Name = "GeekConf", Surname = "Skuratovič", Email = "skura@one.lt", PhoneNumber = "+37067949473", Citizenship = "USA", BirthDate = new DateTime(2017, 10, 18), Address = "Zmoniu", CountryOfResidence="Poland",BasisfOfRepresentation= "Occupation or power of attorney" });
        }
        public Task AddCompanyUBO(ClientModel model, int newId)
        {
            model.Id = clients.Max(c => c.Id) + 1;
            model.UboId = newId;
            model.ClientCounter = model.UboId;
            clients.Add(model);
            return Task.CompletedTask;
        }

        public Task AddCompanyCEO(ClientModel model, int newId)
        {
            model.Id = clients.Max(c => c.Id) + 1;
            model.CeoId = newId;
            clients.Add(model);
            return Task.CompletedTask;
        }

        
        public Task<ClientModel> Delete(string personal)
        {
            return Task.Run(() =>
            {
                var ubo= clients.First(p => p.Email == personal);
                ubo.Disabled = true;
                return ubo;
            });

        }

        public Task<IEnumerable<ClientModel>> GetAll()
        {
            return Task.Run(() => clients.AsEnumerable());
        }

        public Task<ClientModel> GetById(int id)
        {
            return Task.Run(() => clients.First(c => c.Id == id));
        }


        
    }
}
