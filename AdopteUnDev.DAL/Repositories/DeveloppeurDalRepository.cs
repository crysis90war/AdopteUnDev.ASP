using AdopteUnDev.DAL.Interfaces;
using AdopteUnDev.DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUnDev.DAL.Repositories
{
    public class DeveloppeurDalRepository : IDeveloppeurDalRepository
    {
        public void RegisterDev(DeveloppeurDalEntity entity)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");

            string jsonBody = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            using (HttpResponseMessage message = client.PostAsync("Developpeur/registerDev", content).Result)
            {
                if (!message.IsSuccessStatusCode)
                    throw new HttpRequestException();
            }
        }


    }
}
