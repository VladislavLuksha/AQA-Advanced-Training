using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Core.Entities
{
    [Serializable] 
    public class ConfigList
    {
        [XmlAttribute(AttributeName = "name")]
        public string BrowserName { get; set; }

        [XmlElement(ElementName = "user")]
        public List<User> Users { get; set; } = new List<User>();

        public ConfigList() { }

        public override string ToString() => $"Browser: {this.BrowserName}\n" +
            $"{string.Join("\n", Users)}";
    }
}
