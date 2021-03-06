﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace DotNetCoreService
{
    public static class Program
    {
        public static void Main()
        {
            var host = new WebHostBuilder().UseKestrel()
                                           .UseContentRoot(Directory.GetCurrentDirectory())
                                           .UseIISIntegration()
                                           .UseStartup<Startup>()
                                           .Build();

            host.Run();
        }
    }
}