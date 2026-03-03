using SqlSugar;

namespace WebApiOpcServer.Model
{
    [SugarTable("TB_WorkOrderManagement")]
    public class WorkOrderManagement
    {
        /// <summary>
        /// 工作订单ID，主键，自增
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int JobId { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// 工作订单名称
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public int ArticleId { get; set; }

        /// <summary>
        /// 工作订单数量
        /// </summary>
        public int JobQuantity { get; set; }

        /// <summary>
        /// 批次数量
        /// </summary>
        public int BatchQuantity { get; set; }

        /// <summary>
        /// 合格数量
        /// </summary>
        public int OK { get; set; }

        /// <summary>
        /// 不合格数量
        /// </summary>
        public int NG { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatTime { get; set; }
    }
}
