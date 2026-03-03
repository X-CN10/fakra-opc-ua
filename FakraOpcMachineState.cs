using Opc.Ua;
using Quickstarts.FakraOpc;
using SqlSugar;
using WebApiOpcServer.Model;
namespace Quickstarts.FakraOpc
{
    public partial class MachineState
    {
        string connStr = "server=.;uid=sa;pwd=123456;Initial Catalog=Hosver_MES_ProductionInfo;Encrypt=True;TrustServerCertificate=True;";
        //string connStr = "server=.;uid=sa;pwd=qwe123;Initial Catalog=Hosver_MES_ProductionInfoV1;Encrypt=True;TrustServerCertificate=True;";
        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            AddJob.OnCall = OnAddJob;
            DeleteJob.OnCall = OnDeleteJob;
            GenerateReport.OnCall = OnGenerateValues;
        }
        protected virtual ServiceResult OnGenerateValues(
           ISystemContext context,
           MethodState method,
           NodeId objectId,
           string jobDescription,
           ref string jobId)
        {
            return ServiceResult.Good;
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
                using (var db = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.SqlServer,
                    ConnectionString = connStr,
                    IsAutoCloseConnection = true,
                    MoreSettings = new ConnMoreSettings()
                    {
                        IsWithNoLockQuery = true
                    }
                }))
                {
                    Console.WriteLine("接收到Addjob调用。。。");
                    var work = new WorkOrderManagement
                    {
                        TypeId = "Samples",
                        JobName = jobName,
                        JobQuantity = (int)jobQuantity,
                        BatchQuantity = (int)batchQuantity,
                        ArticleId = (int)articleId,
                        CreatTime = DateTime.Now,
                    };
                    var JobId = db.Insertable(work).ExecuteReturnIdentity();
                    if (JobId <= 0) 
                    {
                        return new ServiceResult(Opc.Ua.StatusCodes.BadInternalError);
                    }
                    jobId = (uint)JobId;

                    return ServiceResult.Good;
                };
            }
            catch (Exception) 
            {
                return new ServiceResult(Opc.Ua.StatusCodes.BadInternalError);
            }
        }
        protected virtual ServiceResult OnDeleteJob(
           ISystemContext context,
           MethodState method,
           NodeId objectId,
           uint JobId)
        {
            try
            {
                using (var db = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.SqlServer,
                    ConnectionString = connStr,
                    IsAutoCloseConnection = true,
                    MoreSettings = new ConnMoreSettings()
                    {
                        IsWithNoLockQuery = true
                    }
                }))
                {
                    var res = db.Deleteable<WorkOrderManagement>(JobId).ExecuteCommand();
                    if (res <= 0) 
                    {
                        return new ServiceResult(Opc.Ua.StatusCodes.BadInternalError);
                    }
                    return ServiceResult.Good;
                };
            }
            catch (Exception)
            {
                return new ServiceResult(Opc.Ua.StatusCodes.BadInternalError);
            }
        }
    }
}
