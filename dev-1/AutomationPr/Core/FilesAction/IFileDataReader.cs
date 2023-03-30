using ConsoleApp1.Entities;

namespace Core.Provider
{
    public interface IFileDataReader
    {
        Config DeselizationConfigFromFile(string fileName);
    }
}
