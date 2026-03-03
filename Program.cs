using Microsoft.Extensions.Options;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System.Threading.Tasks;

namespace WebApiOpcServer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<FakraOpcNodeManagerFactory>(provider =>
            {
                return new FakraOpcNodeManagerFactory();
            });
            builder.Services.AddSingleton<FakraOpcServer>(provider =>
            {
                return new FakraOpcServer();
            });
            builder.Services.AddControllers();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                try
                {
                    ApplicationInstance application = new ApplicationInstance();
                    application.ConfigSectionName = "FakraOpcServer";
                    if (string.IsNullOrEmpty(application.ConfigSectionName))
                    {
                        throw new InvalidOperationException("ConfigSectionName is not set");
                    }
                    await application.LoadApplicationConfigurationAsync(false);
                    await application.CheckApplicationInstanceCertificatesAsync(false);
                    var server = scope.ServiceProvider.GetRequiredService<FakraOpcServer>();
                    var NodeManagerFactory = scope.ServiceProvider.GetRequiredService<FakraOpcNodeManagerFactory>();
                    server.AddNodeManager(NodeManagerFactory);
                    await application.StartAsync(server);
                    Console.WriteLine("Endpoints:");
                    foreach (var endpoint in server.GetEndpoints().DistinctBy(x => x.EndpointUrl))
                    {
                        Console.WriteLine(endpoint.EndpointUrl);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                }
            }

            app.Lifetime.ApplicationStopping.Register(async() =>
            {
                using var scope = app.Services.CreateScope();
                var server = scope.ServiceProvider.GetRequiredService<FakraOpcServer>();
                await server.StopAsync();
            });


            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
