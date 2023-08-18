using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.Models
{
    public class Job
    {
        public int id { get; set; }

        public string company { get; set; }

        public string function { get; set; }

        public float payment { get; set; }

        public int hoursPerWeek { get; set; }

        public string description { get; set; }
    }
}
