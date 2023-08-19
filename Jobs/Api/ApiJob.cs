using System;
using Jobs.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Jobs.Api
{
    public class ApiJob
    {

        public List<Job> GetAllJobs()
        {
            List<Job> result = new List<Job>();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("job/GetAll");

            result = JsonConvert.DeserializeObject<List<Job>>(response.data);

            return result;
        }

        public Job GetJob(int id)
        {
            Job result = new Job();
            ApiBase api = new ApiBase();

            Result response = api.GetComand("job/Get?id=" + id);

            if (result != null && response.success)
            {
                result = JsonConvert.DeserializeObject<Job>(response.data);
            }

            return result;
        }

        public Result AddJob(Job job)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(job);

            Result result = api.PostComand("job/Add", parameters);

            return result;
        }

        public Result UpdateJob(Job job)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(job);

            Result result = api.PutComand("job/Update", parameters);

            return result;
        }

        public bool DeleteJob(int id)
        {
            ApiBase api = new ApiBase();

            string parameters = JsonConvert.SerializeObject(id);

            Result response = api.DeleteComand("job/Delete?id=" + id);

            bool result = response.success;

            return result;
        }
    }
}
