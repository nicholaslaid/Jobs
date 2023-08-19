using Jobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Jobs.Global
{
    public class Config
    {
        //Api
        public static string apiBaseUrl = "http://localhost:5284/api/";

        public static Job tempJob = new Job();
        public static bool edit = false;
    }
}
