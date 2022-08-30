using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFramework_API.BL
{
    public class GenericDTO
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}