﻿using Jobs.Global;
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
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage response = client.GetAsync(Config.apiBaseUrl + "home/Check").Result;
            string responseString = response.Content.ReadAsStringAsync().Result;

            bool result = Convert.ToBoolean(responseString);

            return result;
        }

        public Result GetComand(string url)
        {
            Result result = new Result();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage response = client.GetAsync(Config.apiBaseUrl + url).Result;
            string responseString = response.Content.ReadAsStringAsync().Result;

            result = JsonConvert.DeserializeObject<Result>(responseString);

            return result;

        }

        public Result PostComand(string url, string parameters)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpContent content = new StringContent(parameters, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(Config.apiBaseUrl + url, content).Result;
            string responseString = response.Content.ReadAsStringAsync().Result;

            Result result = JsonConvert.DeserializeObject<Result>(responseString);

            return result;
        }

        public Result PutComand(string url, string parameters)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpContent content = new StringContent(parameters, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(Config.apiBaseUrl + url, content).Result;
            string responseString = response.Content.ReadAsStringAsync().Result;

            Result result = JsonConvert.DeserializeObject<Result>(responseString);

            return result;
        }

        public Result DeleteComand(string url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage response = client.DeleteAsync(Config.apiBaseUrl + url).Result;
            string responseString = response.Content.ReadAsStringAsync().Result;

            Result result = JsonConvert.DeserializeObject<Result>(responseString);

            return result;


        }
    }
}
