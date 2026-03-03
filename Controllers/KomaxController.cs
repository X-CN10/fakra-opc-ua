using Microsoft.AspNetCore.Mvc;
using Opc.Ua;
using Quickstarts.FakraOpc;
using WebApiOpcServer.Model;

namespace WebApiOpcServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KomaxController : ControllerBase
    {
        private readonly FakraOpcNodeManagerFactory _opcUaServer;
        private readonly ILogger<KomaxController> _logger;

        public KomaxController(ILogger<KomaxController> logger, FakraOpcNodeManagerFactory opcUaServer)
        {
            _logger = logger;
            _opcUaServer = opcUaServer;
        }

        [HttpPost("ProductionStartedEventTigger")]
        public res ProductionStartedEventTigger(EventParam p)
        {
            var e = new ProductionStartedEventState(null);
            e.Initialize(_opcUaServer.NodeManager.SystemContext,null,(EventSeverity)0,null);

            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.JobId, _opcUaServer.NodeManager.NamespaceIndex), p.JobId, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.GoodPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.GoodPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BadPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.BadPartCount, false);

            _opcUaServer.NodeManager.Server.ReportEvent(e);

            return new res{
                Suscess = true,
                Message = string.Empty
            };
        }
    }
}
