using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class App
    {
        public string Key { get; set; }
        public Api Api { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
    }


    public class Api
    {
        public string Name { get; set; }
    }
}



