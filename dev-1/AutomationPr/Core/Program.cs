using AutomationPr;
using ConsoleApp1.FilesAction;
using Core.FileReaders;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileAction xmlDataProvider = new XmlDataProvider();
            var config = xmlDataProvider.DeselizationConfigFromFile("config.xml");
          
            new ConfigHelper().PrintConfigInformation(config);
            new ConfigHelper().PrintIncorrectConfigInformation(config);

            IFileAction jsonDataProvider = new JsonDataProvider();
            jsonDataProvider.SerelizationConfigInFile(config);
        }
    }
}
