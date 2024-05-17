using Netwise___task.Class;

namespace Netwise___task.Services
{
    public interface IFileService
    {
        void CreateFileTXT(string fileName);
        bool SaveFile(Fact fact, string fileName);
        
    }
}