using Microsoft.Extensions.DependencyInjection;
using Netwise___task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Netwise___task.Class
{
    public class Connection
    {
        private readonly IConnectionService connectionService;
        private readonly IFileService fileService;
        public Connection(IConnectionService _connectionService, IFileService _fileService)
        {
            connectionService = _connectionService;
            fileService = _fileService;
        }

        public async Task<bool> SaveJSON(string fileName)
        {
            string apiURL = "https://catfact.ninja/fact";
            var jsonFact = await connectionService.GetFromApiAsync(apiURL);

            if (jsonFact != null)
            {
                Fact? fact = JsonSerializer.Deserialize<Fact>(jsonFact);
                if (fact == null || !fileService.SaveFile(fact, fileName))
                {
                    Console.WriteLine("Something went wrong! (file)");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Something went wrong! (API)");
                return false;
            }


        }

        public void CreateFile(string fileName)
        {
            fileService.CreateFileTXT(fileName);
        }
    }
}
