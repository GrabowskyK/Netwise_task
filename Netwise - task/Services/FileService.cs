using Netwise___task.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netwise___task.Services
{
    public class FileService : IFileService
    {
        private string workingDirectory = Environment.CurrentDirectory;
        public void CreateFileTXT(string fileName)
        {
            string path = Directory.GetParent(workingDirectory)?.Parent?.Parent?.FullName + "/" + fileName + ".txt";
            using (FileStream fileStream = File.Create(path)) { }
        }

        public bool SaveFile(Fact fact, string fileName)
        {
            try
            {
                string path = Directory.GetParent(workingDirectory)?.Parent?.Parent?.FullName + "/" + fileName + ".txt";
                Console.WriteLine(path);
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(fact.fact + "; " + fact.length);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
