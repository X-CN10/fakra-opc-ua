using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Opc.Ua;
using Quickstarts.FakraOpc;

namespace WebApiOpcServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly FakraOpcNodeManagerFactory _opcUaServer;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, FakraOpcNodeManagerFactory opcUaServer)
        {
            _logger = logger; 
            _opcUaServer = opcUaServer;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            TranslationInfo info = new TranslationInfo(
                        "SystemCycleStarted",
                        "en-US",
                        "The system cycle '{0}' has started.",
                        0);

            // construct the event.
            SystemCycleStatusEventState e = new SystemCycleStatusEventState(null);

            e.Initialize(
                 _opcUaServer.NodeManager.SystemContext,
                null,
                (EventSeverity)0,
                new LocalizedText(info));


            e.SetChildValue(_opcUaServer.NodeManager.SystemContext, Opc.Ua.BrowseNames.SourceName, "System", false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext, Opc.Ua.BrowseNames.SourceNode, Opc.Ua.ObjectIds.Server, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext, 
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.CycleId, _opcUaServer.NodeManager.NamespaceIndex), 108.ToString(), false);
            _opcUaServer.NodeManager.Server.ReportEvent(e);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
