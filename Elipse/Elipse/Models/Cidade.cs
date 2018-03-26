using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace Elipse.Models
{
    [Serializable, DataContract, XmlRoot("cidade")]
    public class Cidade
    {

        [DataMember, XmlElement(ElementName = "nome")]
        public string  Nome { get; set; }

        [DataMember, XmlElement(ElementName = "uf")]
        public string Uf { get; set; }

        [DataMember,XmlElement(ElementName = "id")]
        public int Id { get; set; }
    }
}