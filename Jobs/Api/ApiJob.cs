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
            List<Job> listjobs = new List<Job>();
            ApiBase api = new ApiBase();

            Result result = api.GetCommand("job/GetAll");

            listjobs = JsonConvert.DeserializeObject<List<Job>>(result.data);
                return listjobs;
        }
    }
}
