using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StarterM.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(config => {
                    //config.AddJsonFile("profile.json");
                    config.AddJsonFile("profile.json", true, true); //�Y�ɧ�s
                    config.AddInMemoryCollection(
                        new Dictionary<string, string>
                        {
                            [nameof(WebsiteProfile.Email)] = "memory@aaa.com",
                            [nameof(WebsiteProfile.TemeColor)] = "orange"
                        });
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
