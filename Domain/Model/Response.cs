using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Response<T>
    {
        public Response(string error, int statuscode = 200)
        {
            Erors = error;
            StatusCode = statuscode;
        }
        public Response(T result)
        {
            Result = result;
            Erors = null;
        }

        public int StatusCode { get; set; }
        public string Erors { get; set; }
        public T Result { get; set; }
    }
}
