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
        public DeveloppeurDalEntity LoginDev(string email, string password)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");

            string jsonBody = JsonConvert.SerializeObject(new { email = email, pswd = password });
            HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            using (HttpResponseMessage message = client.PostAsync("Developpeur/Login", content).Result)
            {
                if (!message.IsSuccessStatusCode)
                    throw new HttpRequestException();

                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<DeveloppeurDalEntity>(json);
            }
        }

        public void RegisterDev(DeveloppeurDalEntity entity)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/api/");

            string jsonBody = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            using (HttpResponseMessage message = client.PostAsync("Developpeur/register", content).Result)
            {
                if (!message.IsSuccessStatusCode)
                    throw new HttpRequestException();
            }
        }


    }
}
