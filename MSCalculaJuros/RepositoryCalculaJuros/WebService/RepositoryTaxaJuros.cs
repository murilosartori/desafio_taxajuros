using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCalculaJuros.WebService
{
    public class RepositoryTaxaJuros
    {
        public IRestResponse GetTaxaJuros()
        {
            try
            {
                var client = new RestClient("http://localhost:51752/taxajuros");
                var request = new RestRequest(Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };

                return client.Execute(request);
            }
            catch (Exception ex)
            {
                throw new Exception($"Serviço Taxa de Juros indisponivel. {ex.Message}");
            }
        }
    }
}
