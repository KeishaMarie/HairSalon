using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HairSalon
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseISSIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}