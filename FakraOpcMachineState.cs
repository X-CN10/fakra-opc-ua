using Opc.Ua;
using Quickstarts.FakraOpc;
using SqlSugar;
using WebApiOpcServer;
using WebApiOpcServer.Model;

namespace Quickstarts.FakraOpc
{
    public partial class MachineState
    {
        private FakraOpcNodeManager m_nodeManager;
        private uint m_nextJobId = 0;
        private readonly object m_jobIdLock = new object();

        string connStr = "Data Source=127.0.0.1;Initial Catalog=Hosver_MES_ProductionInfo;User Id=sa;Password=qwe123;TrustServerCertificate=True";

        public void SetNodeManager(FakraOpcNodeManager nodeManager)
        {
            m_nodeManager = nodeManager;
        }

        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            AddJob.OnCall = OnAddJob;
            DeleteJob.OnCall = OnDeleteJob;
            ActivateJob.OnCall = OnActivateJob;
            GenerateReport.OnCall = OnGenerateReport;

            // spec: ProductionStatusEnum.MachineNotStarted = 2
            ProductionStatus.Value = 2;
            // spec: JobStateEnum.Initial = 0
            ActiveJobState.Value = 0;
        }

        private uint AllocateJobId()
        {
            lock (m_jobIdLock)
            {
                return ++m_nextJobId;
            }
        }

        protected virtual ServiceResult OnAddJob(
           ISystemContext context,
           MethodState method,
           NodeId objectId,
           string jobName,
           uint jobQuantity,
           uint batchQuantity,
           uint articleId,
           ref uint jobId)
        {
            try
            {
                Console.WriteLine($"[AddJob] Called: JobName={jobName}, JobQuantity={jobQuantity}, BatchQuantity={batchQuantity}, ArticleId={articleId}");

                if (string.IsNullOrEmpty(jobName) || jobQuantity == 0 || batchQuantity == 0)
                {
                    Console.WriteLine("[AddJob] Failed: missing or invalid arguments");
                    return new ServiceResult(Opc.Ua.StatusCodes.BadArgumentsMissing);
                }

                if (!m_nodeManager.ArticleExists(articleId))
                {
                    Console.WriteLine($"[AddJob] Failed: Article {articleId} not found");
                    return new ServiceResult(Opc.Ua.StatusCodes.BadNoMatch);
                }

                jobId = AllocateJobId();

                m_nodeManager.AddJob(this.JobList, jobId, jobName, jobQuantity, batchQuantity, articleId);

                Console.WriteLine($"[AddJob] Succeeded: JobId={jobId}");

                try
                {
                    PersistJobToDatabase(jobName, jobQuantity, batchQuantity, articleId, jobId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[AddJob] Database persistence failed (non-critical): {ex.Message}");
                }

                return ServiceResult.Good;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddJob] Exception: {ex}");
                return new ServiceResult(Opc.Ua.StatusCodes.BadInternalError);
            }
        }

        protected virtual ServiceResult OnActivateJob(
           ISystemContext context,
           MethodState method,
           NodeId objectId,
           uint jobId)
        {
            try
            {
                Console.WriteLine($"[ActivateJob] Called: JobId={jobId}");

                var job = m_nodeManager.FindJob(jobId);
                if (job == null)
                {
                    Console.WriteLine($"[ActivateJob] Failed: Job {jobId} not found");
                    return new ServiceResult(Opc.Ua.StatusCodes.BadNotFound);
                }

                // spec: JobStateEnum.Active = 1
                job.JobState.Value = 1;
                job.ActivationTime.Value = DateTime.UtcNow;
                job.ClearChangeMasks(context, true);

                // spec: JobStateEnum.Active = 1
                this.ActiveJobState.Value = 1;
                this.ActiveJobState.ClearChangeMasks(context, true);

                Console.WriteLine($"[ActivateJob] Succeeded: JobId={jobId}");
                return ServiceResult.Good;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ActivateJob] Exception: {ex}");
                return new ServiceResult(Opc.Ua.StatusCodes.BadInternalError);
            }
        }

        protected virtual ServiceResult OnDeleteJob(
           ISystemContext context,
           MethodState method,
           NodeId objectId,
           uint jobId)
        {
            try
            {
                Console.WriteLine($"[DeleteJob] Called: JobId={jobId}");

                if (!m_nodeManager.RemoveJob(jobId))
                {
                    Console.WriteLine($"[DeleteJob] Failed: Job {jobId} not found");
                    return new ServiceResult(Opc.Ua.StatusCodes.BadNotFound);
                }

                Console.WriteLine($"[DeleteJob] Succeeded: JobId={jobId}");

                try
                {
                    DeleteJobFromDatabase(jobId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[DeleteJob] Database deletion failed (non-critical): {ex.Message}");
                }

                return ServiceResult.Good;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteJob] Exception: {ex}");
                return new ServiceResult(Opc.Ua.StatusCodes.BadInternalError);
            }
        }

        protected virtual ServiceResult OnGenerateReport(
           ISystemContext context,
           MethodState method,
           NodeId objectId,
           uint jobId,
           int scope,
           uint scopeId,
           ref NodeId reportFileNode)
        {
            Console.WriteLine($"[GenerateReport] Called: JobId={jobId}, Scope={scope}, ScopeId={scopeId}");
            // TODO: implement report generation
            return ServiceResult.Good;
        }

        private void PersistJobToDatabase(string jobName, uint jobQuantity, uint batchQuantity, uint articleId, uint jobId)
        {
            using var db = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = SqlSugar.DbType.SqlServer,
                ConnectionString = connStr,
                IsAutoCloseConnection = true,
            });

            var work = new WorkOrderManagement
            {
                TypeId = "Samples",
                JobName = jobName,
                JobQuantity = (int)jobQuantity,
                BatchQuantity = (int)batchQuantity,
                ArticleId = (int)articleId,
                CreatTime = DateTime.Now,
            };
            db.Insertable(work).ExecuteReturnIdentity();
        }

        private void DeleteJobFromDatabase(uint jobId)
        {
            using var db = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = SqlSugar.DbType.SqlServer,
                ConnectionString = connStr,
                IsAutoCloseConnection = true,
            });

            db.Deleteable<WorkOrderManagement>((int)jobId).ExecuteCommand();
        }
    }
}
