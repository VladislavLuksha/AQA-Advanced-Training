using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Core.Entities
{
    [Serializable]
    public class User
    {
        [XmlAttribute(AttributeName = "role")]
        public string UserRole { get; set; }

        [XmlElement(ElementName = "login")]
        public string Login { get; set; }

        [XmlElement(ElementName = "password")]
        public string Password { get; set; } = "password";

        [XmlElement(ElementName = "test")]
        public List<string> TestNameList { get; set; } = new List<string>();

        public User() { }
       
        public override string ToString() => $"  {UserRole}: login={this.Login}, password={this.Password}, " +
            $"tests= {string.Join(", ", TestNameList)}";
    }
}
