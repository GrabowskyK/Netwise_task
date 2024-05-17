using Microsoft.Extensions.DependencyInjection;
using Netwise___task.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Netwise___task.Services
{
    public class ConnectionService : IConnectionService
    {
        public async Task<string?> GetFromApiAsync(string apiURL)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiURL);
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                    return content;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}
