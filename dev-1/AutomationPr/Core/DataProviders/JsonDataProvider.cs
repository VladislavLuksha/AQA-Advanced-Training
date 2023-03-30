using ConsoleApp1.Entities;
using ConsoleApp1.FilesAction;
using Core.Entities;
using System.IO;
using System.Text.Json;

namespace Core.FileReaders
{
    public class JsonDataProvider : IFileAction
    {
        public Config DeselizationConfigFromFile(string fileName)
        {
            Config config = new();

            string basePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string pathToFile = Path.GetFullPath(Path.Combine(basePath, @"Config", fileName));

            using (FileStream fstream = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                config = JsonSerializer.DeserializeAsync<Config>(fstream).Result as Config;
            }

            return config;
        }

        public void SerelizationConfigInFile(Config congig)
        {
            string basePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string pathToFile = Path.GetFullPath(Path.Combine(basePath, @"Config"));

            foreach (var cn in congig.configs)
            {
                using (FileStream fstream = new FileStream(@$"{pathToFile}\{cn.BrowserName}.json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.SerializeAsync<ConfigList>(fstream, cn);
                }
            }
        }
    }
}
