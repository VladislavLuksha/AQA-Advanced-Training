using ConsoleApp1.Entities;
using ConsoleApp1.FilesAction;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Core.FileReaders
{
    public class XmlDataProvider : IFileAction
    {
        private XmlSerializer XmlSerializer { get; set; } = new XmlSerializer(typeof(Config));

        private XDocument XDocument { get; set; }

        public XmlDataProvider()
        {
            string basePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string pathToFile = Path.GetFullPath(Path.Combine(basePath, @"Config", "config.xml"));

            XDocument = XDocument.Load(pathToFile);
        }

        public void SerelizationConfigInFile(Config config)
        {
            string basePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string pathToFile = Path.GetFullPath(Path.Combine(basePath, @"Config", "configFile.xml"));

            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                XmlSerializer.Serialize(fs, config);
            }
        }

        public Config DeselizationConfigFromFile(string fileName)
        {
            Config config = new();

            string basePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string pathToFile = Path.GetFullPath(Path.Combine(basePath, @"Config", fileName));

            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                config = (Config)XmlSerializer.Deserialize(fs);
            }

            return config;
        }
    }
}
