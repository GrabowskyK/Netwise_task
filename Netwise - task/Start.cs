using Microsoft.Extensions.DependencyInjection;
using Netwise___task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netwise___task
{
    public class Start
    {
        public static IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
               .AddSingleton<IConnectionService, ConnectionService>()
               .AddSingleton<IFileService, FileService>()
               .BuildServiceProvider();
        }

    }
}
