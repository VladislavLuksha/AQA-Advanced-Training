using ConsoleApp1.Entities;

namespace Core.Provider
{
    public interface IFileDataWriter
    {
        void SerelizationConfigInFile(Config config);
    }
}
