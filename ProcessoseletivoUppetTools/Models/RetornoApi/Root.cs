using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessoseletivoUppetTools.Models.RetornoApi
{
    public class Root
    {
        public bool status { get; set; }
        public string @return { get; set; }
        public virtual Result result { get; set; }
        public string message  { get; set; }
    }
}
