using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICore.Utils
{
    public class HttpResponseException: Exception
    {
        public HttpResponseException(string message, int status = 400) : base(message)
        {
            Status = status;
        }
        public int Status { get; set; }
        public object Value { get; set; }
    }
}
