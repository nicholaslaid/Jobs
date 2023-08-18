using Jobs.Global;
using Jobs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.Api
{
    public class ApiBase
    {
        public bool Check()
        {
            bool result = false;
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                HttpResponseMessage response = client.GetAsync(Config.apiBaseUrl + "home/Check").Result;
                string responseString = response.Content.ReadAsStringAsync().Result;

                result = Convert.ToBoolean(responseString);
            }
            catch (Exception ex)
            { }


            return result;
        }

        public Result GetCommand(string url)
        {
            Result result = new Result();
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                HttpResponseMessage response = client.GetAsync(Config.apiBaseUrl + url).Result;
                string responseString = response.Content.ReadAsStringAsync().Result;

                result = JsonConvert.DeserializeObject<Result>(responseString);
            }
            catch (Exception ex)
            { }


            return result;
        }



    }
}
