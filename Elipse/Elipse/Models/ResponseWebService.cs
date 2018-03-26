using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Elipse.Models
{
    [Serializable, XmlRoot("cidade")]
    public class ResponseWebService: BasePrevisao
    {
        [XmlElement(ElementName = "previsao")]
        public List<Previsao> Previsao { get; set; }
    }
}