using Elipse.Models;
using Elipse.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Http;
using System.Xml;
using System.Xml.Serialization;

namespace Elipse.Controllers
{
    public class PrevisaoController : ApiController
    {
        // GET api/{cidade}/previsao
        public HttpResponseMessage Get(String cidade)
        {
            int codMunicipio = ServicePrevisao.GetCodMunicipio(cidade);

            PrevisaoViewModel previsao = new PrevisaoViewModel();

            if (codMunicipio >0)
                previsao = ServicePrevisao.GetPrevisao(codMunicipio);

            return Request.CreateResponse(HttpStatusCode.OK, previsao); 
        }

        // POST api/previsao
        public void Post([FromBody]string value)
        {
        }

        // PUT api/previsao/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/previsao/5
        public void Delete(int id)
        {
        }
    }
}
