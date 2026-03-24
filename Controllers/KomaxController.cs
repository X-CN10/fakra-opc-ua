using Microsoft.AspNetCore.Mvc;
using Opc.Ua;
using Quickstarts.FakraOpc;
using FakraBrowseNames = Quickstarts.FakraOpc.BrowseNames;
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

        private FakraOpcNodeManager NodeManager => _opcUaServer.NodeManager;
        private MachineState Machine => NodeManager.Machine;
        private ISystemContext Context => NodeManager.SystemContext;
        private ushort NsIndex => NodeManager.NamespaceIndex;

        [HttpGet("ActiveJob")]
        public IActionResult GetActiveJob()
        {
            var jobId = Machine.ActiveJobId;
            if (jobId == 0)
            {
                return Ok(new { activeJobId = 0, message = "No active job" });
            }

            var job = NodeManager.FindJob(jobId);
            return Ok(new
            {
                activeJobId = jobId,
                jobName = job?.JobName?.Value,
                jobState = job?.JobState?.Value,
                goodPartCount = job?.GoodPartCount?.Value,
                badPartCount = job?.BadPartCount?.Value,
                batchCount = job?.BatchCount?.Value
            });
        }

        [HttpPost("WireFinishedEventTigger")]
        public res WireFinishedEventTigger(WireFinishedEventParam p)
        {
            var jobId = Machine.ActiveJobId;
            if (jobId == 0)
                return new res { Suscess = false, Message = "No active job" };

            _logger.LogInformation("[WireFinished] JobId={JobId}, Good={Good}, Bad={Bad}, Wire={Wire}, Batch={Batch}",
                jobId, p.GoodPartCount, p.BadPartCount, p.WireSequenceNumber, p.BatchSequenceNumber);

            UpdateJobCounters(jobId, p.GoodPartCount, p.BadPartCount);

            var e = new WireFinishedEventState(null);
            e.Initialize(Context, null, (EventSeverity)0, null);
            SetEventProperty(e, FakraBrowseNames.JobId, jobId);
            SetEventProperty(e, FakraBrowseNames.GoodPartCount, p.GoodPartCount);
            SetEventProperty(e, FakraBrowseNames.BadPartCount, p.BadPartCount);
            SetEventProperty(e, FakraBrowseNames.BatchSequenceNumber, p.BatchSequenceNumber);
            SetEventProperty(e, FakraBrowseNames.WireSequenceNumber, p.WireSequenceNumber);

            NodeManager.Server.ReportEvent(e);
            return new res { Suscess = true, Message = string.Empty };
        }

        [HttpPost("BatchFinishedEventTigger")]
        public res BatchFinishedEventTigger(BatchFinishedEventParam p)
        {
            var jobId = Machine.ActiveJobId;
            if (jobId == 0)
                return new res { Suscess = false, Message = "No active job" };

            _logger.LogInformation("[BatchFinished] JobId={JobId}, Good={Good}, Bad={Bad}, Batch={Batch}",
                jobId, p.GoodPartCount, p.BadPartCount, p.BatchSequenceNumber);

            UpdateJobCounters(jobId, p.GoodPartCount, p.BadPartCount, p.BatchSequenceNumber);

            var e = new BatchFinishedEventState(null);
            e.Initialize(Context, null, (EventSeverity)0, null);
            SetEventProperty(e, FakraBrowseNames.JobId, jobId);
            SetEventProperty(e, FakraBrowseNames.GoodPartCount, p.GoodPartCount);
            SetEventProperty(e, FakraBrowseNames.BadPartCount, p.BadPartCount);
            SetEventProperty(e, FakraBrowseNames.BatchSequenceNumber, p.BatchSequenceNumber);

            NodeManager.Server.ReportEvent(e);
            return new res { Suscess = true, Message = string.Empty };
        }

        [HttpPost("JobFinishedEventTigger")]
        public res JobFinishedEventTigger(EventParam p)
        {
            var jobId = Machine.ActiveJobId;
            if (jobId == 0)
                return new res { Suscess = false, Message = "No active job" };

            _logger.LogInformation("[JobFinished] JobId={JobId}, Good={Good}, Bad={Bad}", jobId, p.GoodPartCount, p.BadPartCount);

            UpdateJobCounters(jobId, p.GoodPartCount, p.BadPartCount);

            var job = NodeManager.FindJob(jobId);
            if (job != null)
            {
                // spec: JobStateEnum.Finished = 2
                job.JobState.Value = 2;
                job.ClearChangeMasks(Context, true);
            }

            var e = new JobFinishedEventState(null);
            e.Initialize(Context, null, (EventSeverity)0, null);
            SetEventProperty(e, FakraBrowseNames.JobId, jobId);
            SetEventProperty(e, FakraBrowseNames.GoodPartCount, p.GoodPartCount);
            SetEventProperty(e, FakraBrowseNames.BadPartCount, p.BadPartCount);

            NodeManager.Server.ReportEvent(e);
            return new res { Suscess = true, Message = string.Empty };
        }

        [HttpPost("JobStoppedEventTigger")]
        public res JobStoppedEventTigger(EventParam p)
        {
            var jobId = Machine.ActiveJobId;
            if (jobId == 0)
                return new res { Suscess = false, Message = "No active job" };

            _logger.LogInformation("[JobStopped] JobId={JobId}, Good={Good}, Bad={Bad}", jobId, p.GoodPartCount, p.BadPartCount);

            UpdateJobCounters(jobId, p.GoodPartCount, p.BadPartCount);

            var job = NodeManager.FindJob(jobId);
            if (job != null)
            {
                // spec: JobStateEnum.Stopped = 3
                job.JobState.Value = 3;
                job.ClearChangeMasks(Context, true);
            }

            var e = new JobStoppedEventState(null);
            e.Initialize(Context, null, (EventSeverity)0, null);
            SetEventProperty(e, FakraBrowseNames.JobId, jobId);
            SetEventProperty(e, FakraBrowseNames.GoodPartCount, p.GoodPartCount);
            SetEventProperty(e, FakraBrowseNames.BadPartCount, p.BadPartCount);

            NodeManager.Server.ReportEvent(e);
            return new res { Suscess = true, Message = string.Empty };
        }

        [HttpPost("ProductionStartedEventTigger")]
        public res ProductionStartedEventTigger(EventParam p)
        {
            var jobId = Machine.ActiveJobId;
            if (jobId == 0)
                return new res { Suscess = false, Message = "No active job" };

            _logger.LogInformation("[ProductionStarted] JobId={JobId}, Good={Good}, Bad={Bad}", jobId, p.GoodPartCount, p.BadPartCount);

            // spec: ProductionStatusEnum.InProduction = 6
            Machine.ProductionStatus.Value = 6;
            Machine.ProductionStatus.ClearChangeMasks(Context, true);

            var e = new ProductionStartedEventState(null);
            e.Initialize(Context, null, (EventSeverity)0, null);
            SetEventProperty(e, FakraBrowseNames.JobId, jobId);
            SetEventProperty(e, FakraBrowseNames.GoodPartCount, p.GoodPartCount);
            SetEventProperty(e, FakraBrowseNames.BadPartCount, p.BadPartCount);

            NodeManager.Server.ReportEvent(e);
            return new res { Suscess = true, Message = string.Empty };
        }

        [HttpPost("ProductionStoppedEventTigger")]
        public res ProductionStoppedEventTigger(EventParam p)
        {
            var jobId = Machine.ActiveJobId;
            if (jobId == 0)
                return new res { Suscess = false, Message = "No active job" };

            _logger.LogInformation("[ProductionStopped] JobId={JobId}, Good={Good}, Bad={Bad}", jobId, p.GoodPartCount, p.BadPartCount);

            UpdateJobCounters(jobId, p.GoodPartCount, p.BadPartCount);

            // spec: ProductionStatusEnum.JobNotRunning = 4
            Machine.ProductionStatus.Value = 4;
            Machine.ProductionStatus.ClearChangeMasks(Context, true);

            var e = new ProductionStoppedEventState(null);
            e.Initialize(Context, null, (EventSeverity)0, null);
            SetEventProperty(e, FakraBrowseNames.JobId, jobId);
            SetEventProperty(e, FakraBrowseNames.GoodPartCount, p.GoodPartCount);
            SetEventProperty(e, FakraBrowseNames.BadPartCount, p.BadPartCount);

            NodeManager.Server.ReportEvent(e);
            return new res { Suscess = true, Message = string.Empty };
        }

        private void SetEventProperty(BaseEventState e, string browseName, uint value)
        {
            e.SetChildValue(Context, new QualifiedName(browseName, NsIndex), value, false);
        }

        private void UpdateJobCounters(uint jobId, uint goodPartCount, uint badPartCount, uint? batchSequenceNumber = null)
        {
            var job = NodeManager.FindJob(jobId);
            if (job == null) return;

            job.GoodPartCount.Value = goodPartCount;
            job.BadPartCount.Value = badPartCount;
            if (batchSequenceNumber.HasValue)
            {
                job.BatchCount.Value = batchSequenceNumber.Value;
            }
            job.ClearChangeMasks(Context, true);
        }
    }
}
