using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace Elipse.Models
{
    public class Previsao
    {
        [XmlElement(ElementName = "dia")]
        public string Dia { get; set; }

        [XmlElement(ElementName = "maxima")]
        public int Maxima { get; set; }

        [XmlElement(ElementName = "minima")]
        public int Minima { get; set; }
    }
}