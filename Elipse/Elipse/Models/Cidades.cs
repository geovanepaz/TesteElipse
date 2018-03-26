using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace Elipse.Models
{
    [Serializable, DataContract, XmlRoot("cidades")]
    public class Cidades
    {
        [DataMember, XmlElement(ElementName = "cidade")]
        public List<Cidade> Cidade { get; set; }

    }
}