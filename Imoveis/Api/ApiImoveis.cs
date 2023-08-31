using Imoveis.Models;

using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace Imoveis.Api
{
    public class ApiImoveis
    {
        public List<Imoveiss> GetAllImoveis(string filter)
        {
            List<Imoveiss> result = new List<Imoveiss>();
            ApiBase api = new ApiBase();

            Result response = new Result();

            if (!string.IsNullOrEmpty(filter) && !string.IsNullOrWhiteSpace(filter))
                response = api.GetComand("imoveis/GetFilter?filter=" + filter);
            else
                response = api.GetComand("imoveis/GetAll");

            if (response.success == true)
            {
                result = JsonConvert.DeserializeObject<List<Imoveiss>>(response.data);
            }
             


            return result;
        }

        public Imoveiss Get(int id)
        {
            Imoveiss result = new Imoveiss();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("imoveis/Get?id=" + id);

            if (result != null && response.success)
            {
                result = JsonConvert.DeserializeObject<Imoveiss>(response.data);
            }

            return result;
        }


        public Imoveiss GetFilter(string filter)
        {
            Imoveiss result = new Imoveiss();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("imoveis/GetFilter?filter=" + filter);

            if (result != null && response.success)
            {
                result = JsonConvert.DeserializeObject<Imoveiss>(response.data);
            }

            return result;
        }

        public Imoveiss GetBairro(string bairro)
        {
            Imoveiss result = new Imoveiss();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("imoveis/GetBairro?bairro=" + bairro);

            if (result != null && response.success)
            {
                result = JsonConvert.DeserializeObject<Imoveiss>(response.data);
            }

            return result;
        }

        public Imoveiss GetTipo(string tipo)
        {
            Imoveiss result = new Imoveiss();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("imoveis/GetTipo?tipo=" + tipo);

            if (result != null && response.success)
            {
                result = JsonConvert.DeserializeObject<Imoveiss>(response.data);
            }

            return result;
        }
        public Result Add(Imoveiss imoveiss)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(imoveiss);

            Result result = api.PostComand("imoveis/Add", parameters);

            return result;
        }

        public Result Update(Imoveiss imoveiss)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(imoveiss);

            Result result = api.PutComand("imoveis/Update", parameters);

            return result;
        }

        public bool Delete(int id)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(id);

            Result response = api.DeleteComand("imoveis/Delete?id=" + id);

            bool result = response.success;

            return result;
        }
    }
}
