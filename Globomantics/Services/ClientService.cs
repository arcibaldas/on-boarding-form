using System;
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
        public Task Add(ClientModel model)
        {
            model.Id = clients.Max(c => c.Id) + 1;
            model.UserCounter = clients.Max(c => c.UserCounter) + 1;
            if(model.UserCounter==6)
            {
                for (var i = 1; i <= 6; i++)
                {
                    clients.RemoveAll(p => p.UserCounter == i);
                }
            model.UserCounter = clients.Max(c => c.UserCounter) + 1;
            }
            clients.Add(model);
            return Task.CompletedTask;
        }

        public Task Delete(ClientModel model)
        {
            model.Id = clients.Max(c => c.Id);
            clients.Remove(model);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<ClientModel>> GetAll(int id)
        {
            return Task.Run(() => clients.Where(p => p.Id == id).AsEnumerable());
        }

        public Task<ClientModel> GetById(int id)
        {
            return Task.Run(() => clients.First(c => c.Id == id));
        }


        /*  public Task<StatisticsModel> GetStatistics()
          {
              return Task.Run(() =>
              {
                  return new StatisticsModel
                  {
                      NumberOfAttendees = clients.Sum(c => c.Address),
                      AverageConferenceAttendees = (int)clients.Average(c => c.Address)
                  };
              });
          }*/
    }
}
