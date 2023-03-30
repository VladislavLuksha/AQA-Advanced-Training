using Core.Entities;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConsoleApp1.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "config")]
    public class Config
    {
        [XmlElement(ElementName = "browser")]
        public List<ConfigList> configs { get; set; } = new List<ConfigList>();

        public Config() { }
    }
}
