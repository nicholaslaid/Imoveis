using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imoveis.Models
{
    public class Result
    {
        public bool success { get; set; }

        public int errorCode { get; set; }

        public string errorMessage { get; set; }

        public string data { get; set; }

        public static implicit operator string(Result v)
        {
            throw new NotImplementedException();
        }
    }
}
