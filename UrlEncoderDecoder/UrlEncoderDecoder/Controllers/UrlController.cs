using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UrlEncoderDecoder.Controllers
{
    public class UrlController : ApiController
    {
        [AcceptVerbs("GET")]
        [ParameterConverter("id")]
        public int Get(int id=0)
        {
            return id;
        }
    }
}
