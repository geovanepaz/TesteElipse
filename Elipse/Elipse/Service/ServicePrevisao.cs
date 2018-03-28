using Elipse.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml.Serialization;

namespace Elipse.Service
{
    public class ServicePrevisao
    {
        public static int GetCodMunicipio(String cidade)
        {
            string url = $"http://servicos.cptec.inpe.br/XML/listaCidades?city={cidade}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            var stream = response.GetResponseStream();

            var reader = new StreamReader(stream);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cidades));

            var cidades = (Cidades)xmlSerializer.Deserialize(reader);

            if (cidades.Cidade.Count > 0)
                return cidades.Cidade[0].Id;
            else
                return -1;
        }

        public static PrevisaoViewModel GetPrevisao(int id)
        {


            string url = $"http://servicos.cptec.inpe.br/XML/cidade/{id}/previsao.xml";

            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            var stream = response.GetResponseStream();
            var reader = new StreamReader(stream);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ResponseWebService));

            var responsePrev = (ResponseWebService)xmlSerializer.Deserialize(reader);

            Previsao tempDiaSeguinte = null;
            string dateCurrent = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

            foreach (var item in responsePrev.Previsao)
            {
                if (item.Dia.Equals(dateCurrent))
                    tempDiaSeguinte = item;
            }

            var prev =
                new PrevisaoViewModel
                {
                    Nome = responsePrev.Nome,
                    Uf = responsePrev.Uf,
                    Id = id,
                    Atualizacao = responsePrev.Atualizacao,
                    Previsao = tempDiaSeguinte,
                };

            return prev;

        }
}
}