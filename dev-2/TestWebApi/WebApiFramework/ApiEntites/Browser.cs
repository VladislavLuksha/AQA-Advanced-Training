using System.Collections.Generic;

namespace WebApiFramework.ApiEntites
{
    public class Browser
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public List<User> Users { get; set; } = new();
    }
}
