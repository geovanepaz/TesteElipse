using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Elipse.Models
{
    [Serializable, DataContract(Name = "previsao")]
    public class PrevisaoViewModel : BasePrevisao
    {
        [DataMember(Name = "previsao")]
        public Previsao Previsao { get; set; }

   
    }
}