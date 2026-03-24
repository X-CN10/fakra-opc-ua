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

        [HttpPost("WireFinishedEventTigger")]
        public res WireFinishedEventTigger(WireFinishedEventParam p)
        {
            var e = new WireFinishedEventState(null);
            e.Initialize(_opcUaServer.NodeManager.SystemContext, null, (EventSeverity)0, null);

            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.JobId, _opcUaServer.NodeManager.NamespaceIndex), p.JobId, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.GoodPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.GoodPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BadPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.BadPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BatchSequenceNumber, _opcUaServer.NodeManager.NamespaceIndex), p.BatchSequenceNumber, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.WireSequenceNumber, _opcUaServer.NodeManager.NamespaceIndex), p.WireSequenceNumber, false);
            _opcUaServer.NodeManager.Server.ReportEvent(e);
            try
            {
                return new res
                {
                    Suscess = true,
                    Message = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new res
                {
                    Suscess = false,
                    Message = ex.Message
                };
            }
        }

        [HttpPost("BatchFinishedEventTigger")]
        public res BatchFinishedEventTigger(BatchFinishedEventParam p)
        {
            var e = new BatchFinishedEventState(null);
            e.Initialize(_opcUaServer.NodeManager.SystemContext, null, (EventSeverity)0, null);

            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.JobId, _opcUaServer.NodeManager.NamespaceIndex), p.JobId, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.GoodPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.GoodPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BadPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.BadPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BatchSequenceNumber, _opcUaServer.NodeManager.NamespaceIndex), p.BatchSequenceNumber, false);

            _opcUaServer.NodeManager.Server.ReportEvent(e);
            try
            {
                return new res
                {
                    Suscess = true,
                    Message = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new res
                {
                    Suscess = false,
                    Message = ex.Message
                };
            }
        }

        [HttpPost("JobFinishedEventTigger")]

        public res JobFinishedEventTigger(EventParam p)
        {
            var e = new JobFinishedEventState(null);
            e.Initialize(_opcUaServer.NodeManager.SystemContext, null, (EventSeverity)0, null);

            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.JobId, _opcUaServer.NodeManager.NamespaceIndex), p.JobId, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.GoodPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.GoodPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BadPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.BadPartCount, false);

            _opcUaServer.NodeManager.Server.ReportEvent(e);
            try
            {
                return new res
                {
                    Suscess = true,
                    Message = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new res
                {
                    Suscess = false,
                    Message = ex.Message
                };
            }
        }

        [HttpPost("JobStoppedEventTigger")]
        public res JobStoppedEventTigger(EventParam p)
        {
            var e = new JobStoppedEventState(null);
            e.Initialize(_opcUaServer.NodeManager.SystemContext, null, (EventSeverity)0, null);

            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.JobId, _opcUaServer.NodeManager.NamespaceIndex), p.JobId, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.GoodPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.GoodPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BadPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.BadPartCount, false);

            _opcUaServer.NodeManager.Server.ReportEvent(e);
            try
            {
                return new res
                {
                    Suscess = true,
                    Message = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new res
                {
                    Suscess = false,
                    Message = ex.Message
                };
            }
        }

        [HttpPost("ProductionStartedEventTigger")]
        public res ProductionStartedEventTigger(EventParam p)
        {
            var e = new ProductionStartedEventState(null);
            e.Initialize(_opcUaServer.NodeManager.SystemContext, null, (EventSeverity)0, null);

            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.JobId, _opcUaServer.NodeManager.NamespaceIndex), p.JobId, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.GoodPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.GoodPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BadPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.BadPartCount, false);

            _opcUaServer.NodeManager.Server.ReportEvent(e);
            try
            {
                return new res
                {
                    Suscess = true,
                    Message = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new res
                {
                    Suscess = false,
                    Message = ex.Message
                };
            }
        }

        [HttpPost("ProductionStoppedEventTigger")]
        public res ProductionStoppedEventTigger(EventParam p)
        {
            var e = new ProductionStoppedEventState(null);
            e.Initialize(_opcUaServer.NodeManager.SystemContext, null, (EventSeverity)0, null);

            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.JobId, _opcUaServer.NodeManager.NamespaceIndex), p.JobId, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.GoodPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.GoodPartCount, false);
            e.SetChildValue(_opcUaServer.NodeManager.SystemContext,
                new QualifiedName(Quickstarts.FakraOpc.BrowseNames.BadPartCount, _opcUaServer.NodeManager.NamespaceIndex), p.BadPartCount, false);

            _opcUaServer.NodeManager.Server.ReportEvent(e);
            try
            {
                return new res
                {
                    Suscess = true,
                    Message = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new res
                {
                    Suscess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
