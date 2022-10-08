using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HairSalon
{
  public static void Main(string[] args)
  {
    var host = new WebHostBuilder()
    .UseKestrel()
    .useContentRoot(Directory.GetCurrentDirectory())
    .UseISSIntegration()
    .UseStartup<Startup>()
    .Build();

   host.Run();
  }
}