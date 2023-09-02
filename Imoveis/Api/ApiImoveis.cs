using Imoveis.Models;
using ImoveisApp.Global;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace Imoveis.Api
{
    public class ApiImoveis
    {
        public List<Imoveiss> GetAllImoveis(string token, string filter, string search)
        {
            List<Imoveiss> result = new List<Imoveiss>();
            ApiBase api = new ApiBase();

            Result response = new Result();

            if (!string.IsNullOrEmpty(filter) && !string.IsNullOrWhiteSpace(filter) || !string.IsNullOrEmpty(search) && !string.IsNullOrWhiteSpace(search))
                response = api.GetComand("imoveis/GetWithFilter?token=" + token + "&filter=" + filter + "&search=" + search);
            
            else
                response = api.GetComand("imoveis/GetAll?token=" + token);

            if (response.success == true)
            {
                result = JsonConvert.DeserializeObject<List<Imoveiss>>(response.data);
            }
             


            return result;
        }

        public Imoveiss Get(int id, string token)
        {
            Imoveiss result = new Imoveiss();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("imoveis/Get?id=" + id + "&token=" + token);

            if (result != null && response.success)
            {
                result = JsonConvert.DeserializeObject<Imoveiss>(response.data);
            }

            return result;
        }

        public string GetToken(string key)
        {
            Imoveiss result = new Imoveiss();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("imoveis/GetToken?key=" + key);

            if (response.success)
            {
                Config.token = response.data;
            }
           
            return Config.token;
        }


        public Result Add(Imoveiss imoveis)
        {
            ApiBase api = new ApiBase();

            RequestData request = new RequestData();

            request.imoveis = imoveis;
            request.token = Config.token;

            string parameters = JsonConvert.SerializeObject(request);

            Result result = api.PostComand("imoveis/Add", parameters);

            return result;
        }

        public Result Update(Imoveiss imoveis)
        {
            ApiBase api = new ApiBase();

            RequestData request = new RequestData();
            
            request.imoveis = imoveis;
            request.token = Config.token;
                       
            string parameters = JsonConvert.SerializeObject(request);

            Result result = api.PutComand("imoveis/Update", parameters);

            return result;
        }

        public bool Delete(int id, string token)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(id);

            Result response = api.DeleteComand("imoveis/Delete?id=" + id + "&token=" + token);

            bool result = response.success;

            return result;
        }
    }
}
