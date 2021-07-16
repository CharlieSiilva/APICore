using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICore.Models
{
    public class APIResponse
    {
        public int result { get; set; }
        public int status { get; set; }
        public string msj { get; set; }
    }
}
