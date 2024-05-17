using Microsoft.Extensions.DependencyInjection;
using Netwise___task.Class;
using Netwise___task.Services;
using System;
using System.IO;
using System.ComponentModel.Design;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Netwise___task
{
    class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = Start.ConfigureServices();
            var connectionService = serviceProvider.GetService<IConnectionService>();
            var fileService = serviceProvider.GetService<IFileService>();

            Connection connection = new Connection(connectionService!, fileService!);
            connection.SaveJSON("facts").Wait(); //Main blokuje inne asynci
            //https://stackoverflow.com/questions/31281073/debugger-stops-after-async-httpclient-getasync-call-in-visual-studio

            connection.CreateFile("nazwaPliku"); //tworzenie pliku
        }
    }
}
