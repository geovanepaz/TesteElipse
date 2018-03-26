using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Elipse.Models
{
    [Serializable, DataContract, XmlRoot("cidade")]
    public class BasePrevisao : Cidade
    {
        [DataMember, XmlElement(ElementName = "atualizacao")]
        public string Atualizacao { get; set; }
    }
}