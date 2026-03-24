[English](README.en.md) | [中文](README.md)

# WebApiOpcServer

基于 Schleuniger TransferLine 机器的 OPC UA 服务器，实现了 DiIT CAO 接口规范。采用 ASP.NET Core 8 与 OPC Foundation .NET Standard SDK 构建，同时提供 OPC UA 端点（供 MES 系统集成）和 Web API（供机器侧触发事件）。

## 系统架构

```
┌──────────────┐     OPC UA (opc.tcp)     ┌─────────────────────┐
│  DiIT CAO    │◄────────────────────────►│  WebApiOpcServer     │
│  (MES)       │  订阅 / 方法调用          │                     │
└──────────────┘                           │  ┌───────────────┐  │
                                           │  │ OPC UA Server  │  │
┌──────────────┐     HTTP REST API         │  │ (端口 62546)   │  │
│  机器控制器   │─────────────────────────►│  ├───────────────┤  │
│  (Machine)   │  触发事件                 │  │ Web API        │  │
└──────────────┘                           │  │ (端口 5000)    │  │
                                           │  └───────┬───────┘  │
                                           │          │          │
                                           │  ┌───────▼───────┐  │
                                           │  │  SQL Server    │  │
                                           │  │  (作业存储)     │  │
                                           │  └───────────────┘  │
                                           └─────────────────────┘
```

服务器作为 MES 系统（DiIT CAO）与物理机器之间的桥梁。MES 通过 OPC UA 协议管理作业、读取产品信息并订阅生产事件；机器控制器通过 REST API 触发事件。

## 接口规范

基于 **DiIT CAO - Schleuniger TransferLine - OPC UA 接口规范 v1.3**。

### OPC UA 命名空间

| 命名空间索引 | URI |
|---|---|
| 0 | `http://opcfoundation.org/UA/` |
| 1（内部） | 服务器诊断 |
| 2 | `http://schleuniger.com/Default/` |

### 地址空间

```
Objects (i=85)
└── Machine (ns=2;s=Machine)
    ├── ProductionStatus      : Int32 (R)        — 生产状态枚举
    ├── ActiveJobState        : Int32 (R)        — 作业状态枚举
    ├── JobList               : JobListType       — 作业列表容器
    │   ├── Job_1             : JobInfoType
    │   ├── Job_2             : JobInfoType
    │   └── ...
    ├── ArticleList           : ArticleListType   — 产品列表容器
    │   ├── Article_1         : ArticleType
    │   ├── Article_2         : ArticleType
    │   └── ...
    ├── AddJob()              — 创建新作业
    ├── ActivateJob()         — 激活作业
    ├── DeleteJob()           — 删除作业
    └── GenerateReport()      — 生成生产报告
```

### 对象类型

#### MachineType

根入口节点，位于 `Objects` 文件夹下，支持事件订阅。

| 引用类型 | 子节点 | 数据类型 / 类型定义 | 访问权限 |
|---|---|---|---|
| HasProperty | ProductionStatus | Int32 (ProductionStatusEnum) | 只读 |
| HasProperty | ActiveJobState | Int32 (JobStateEnum) | 只读 |
| HasComponent | JobList | JobListType | 只读 |
| HasComponent | ArticleList | ArticleListType | 只读 |
| HasComponent | AddJob | Method | — |
| HasComponent | ActivateJob | Method | — |
| HasComponent | DeleteJob | Method | — |
| HasComponent | GenerateReport | Method | — |

#### JobInfoType

| 属性 | 数据类型 | 访问权限 | 说明 |
|---|---|---|---|
| JobId | UInt32 | 只读 | 由服务器分配的唯一 ID |
| JobName | String | 只读 | 客户端通过 AddJob 分配的名称 |
| JobQuantity | UInt32 | 只读 | 总生产数量 |
| GoodPartCount | UInt32 | 只读 | 当前合格品数量 |
| BadPartCount | UInt32 | 只读 | 当前不合格品数量 |
| BatchQuantity | UInt32 | 只读 | 每批次数量 |
| BatchCount | UInt32 | 只读 | 已完成的批次数 |
| ArticleId | UInt32 | 只读 | 所生产产品的 ID |
| JobState | Int32 | 只读 | 当前作业状态 (JobStateEnum) |
| ActivationTime | DateTime | 只读 | 作业激活时间（可选） |

#### ArticleType

| 属性 | 数据类型 | 访问权限 | 说明 |
|---|---|---|---|
| ArticleId | UInt32 | 只读 | 产品唯一标识 |
| ArticleName | String | 只读 | 产品名称 |
| ArticleNumber | String | 只读 | 产品编号（MES 用于匹配 Leadset） |
| CanBeProduced | Boolean | 只读 | 当前机器设置是否可生产该产品 |

### 枚举类型

#### ProductionStatusEnum（生产状态）

| 名称 | 值 | 说明 |
|---|---|---|
| MachineNotAvailable | 0 | 机器关闭或未连接 |
| MachineNotHomed | 1 | 机器已开机但未初始化 |
| MachineNotStarted | 2 | 机器已初始化但未启动 |
| JobNotActivated | 3 | 机器运行中但作业未加载/激活 |
| JobNotRunning | 4 | 作业已加载并激活但未开始 |
| JobRunning | 5 | 作业运行中，准备处理零件 |
| InProduction | 6 | 零件已插入，机器正在生产 |
| AdjustMode | 7 | 机器处于调整模式 |
| HasError | 8 | 机器处于错误状态 |

#### JobStateEnum（作业状态）

| 名称 | 值 | 说明 |
|---|---|---|
| Initial | 0 | 无活动作业 |
| Active | 1 | 作业活动且正在运行 |
| Finished | 2 | 作业已完成 |
| Stopped | 3 | 作业已停止 |

### 方法

#### AddJob — 创建作业

创建一个新的生产作业。服务器会验证输入参数，在 JobList 中创建 JobInfoType 实例节点，并分配唯一 JobId。

| 方向 | 名称 | 数据类型 | 说明 |
|---|---|---|---|
| 输入 | JobName | String | 作业名称 |
| 输入 | JobQuantity | UInt32 | 总生产数量 |
| 输入 | BatchQuantity | UInt32 | 每批次数量 |
| 输入 | ArticleId | UInt32 | 要生产的产品 ID |
| 输出 | JobId | UInt32 | 分配的唯一作业 ID |

| 返回状态码 | 说明 |
|---|---|
| Good | 作业创建成功 |
| BadArgumentsMissing | 输入参数缺失或无效 |
| BadNoMatch | 指定的 ArticleId 不存在 |
| BadInternalError | 服务器内部错误 |

#### ActivateJob — 激活作业

激活作业以进行生产（下载配方、释放机器）。激活后 Job 的 `JobState` 变为 `Active`，`ActivationTime` 被设置，Machine 的 `ActiveJobState` 同步更新。

| 方向 | 名称 | 数据类型 | 说明 |
|---|---|---|---|
| 输入 | JobId | UInt32 | 要激活的作业 ID |

| 返回状态码 | 说明 |
|---|---|
| Good | 作业激活成功 |
| BadNotFound | 指定的 JobId 不存在 |
| BadInternalError | 服务器内部错误 |

#### DeleteJob — 删除作业

从机器中删除作业，移除 JobList 中对应的节点。

| 方向 | 名称 | 数据类型 | 说明 |
|---|---|---|---|
| 输入 | JobId | UInt32 | 要删除的作业 ID |

| 返回状态码 | 说明 |
|---|---|
| Good | 作业删除成功 |
| BadNotFound | 指定的 JobId 不存在 |
| BadInternalError | 服务器内部错误 |

#### GenerateReport — 生成报告

生成生产报告文件（OPC UA FileType）。

| 方向 | 名称 | 数据类型 | 说明 |
|---|---|---|---|
| 输入 | JobId | UInt32 | 作业 ID |
| 输入 | Scope | Int32 | 报告范围（0=作业, 1=批次, 2=线缆） |
| 输入 | ScopeId | UInt32 | 范围内的具体 ID |
| 输出 | ReportFileNode | NodeId | 生成的报告文件节点 ID |

### 事件类型

所有生产事件类型均为 `BaseEventType` 的直接子类型。

#### WireFinishedEventType — 线缆完成

单根线缆生产完成时触发。

| 属性 | 数据类型 |
|---|---|
| JobId | UInt32 |
| BatchSequenceNumber | UInt32 |
| WireSequenceNumber | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### BatchFinishedEventType — 批次完成

一个批次的线缆生产完成时触发。

| 属性 | 数据类型 |
|---|---|
| JobId | UInt32 |
| BatchSequenceNumber | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### JobFinishedEventType — 作业完成

整个作业生产完成时触发。

| 属性 | 数据类型 |
|---|---|
| JobId | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### JobStoppedEventType — 作业停止

作业被提前停止时触发。

| 属性 | 数据类型 |
|---|---|
| JobId | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### ProductionStartedEventType — 生产开始

物理生产开始时触发。

| 属性 | 数据类型 |
|---|---|
| JobId | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### ProductionStoppedEventType — 生产停止

物理生产停止时触发。

| 属性 | 数据类型 |
|---|---|
| JobId | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

### 事件序列（典型工作流）

```
ProductionStarted   ← 操作员插入线缆
WireFinished        ← 每根线缆完成时重复
BatchFinished       ← 每个批次完成时重复
JobFinished         ← 整个作业完成
ProductionStopped   ← 机器停止处理
```

## Web API（机器侧接口）

供机器控制器触发 OPC UA 事件的 REST 端点。

### POST /Komax/ProductionStartedEventTigger

在 OPC UA 服务器上触发 `ProductionStartedEvent` 事件。

**请求体：**

```json
{
  "jobId": 1,
  "goodPartCount": 10,
  "badPartCount": 0
}
```

**响应：**

```json
{
  "suscess": true,
  "message": ""
}
```

## 项目结构

```
WebApiOpcServer/
├── Program.cs                      — 应用入口，启动 OPC UA + Web API
├── FakraOpcServer.cs               — OPC UA StandardServer 实现
├── FakraOpcNodeManager.cs          — 自定义节点管理器，管理地址空间及 Job/Article 动态节点
├── FakraOpcNodeManagerFactory.cs   — 节点管理器工厂
├── FakraOpcMachineState.cs         — Machine 业务逻辑（AddJob, ActivateJob, DeleteJob 等方法回调）
├── FakraOpcServerConfiguration.cs  — 服务器配置模型
├── FakraOpcServer.Config.xml       — OPC UA 应用配置文件
├── Controllers/
│   ├── KomaxController.cs          — 事件触发 REST API
│   └── WeatherForecastController.cs— 测试/演示控制器
├── Model/
│   ├── Common.cs                   — 共享 API 模型
│   └── TB_WorkOrderManagement.cs   — SQL Server 作业存储实体
└── ModelDesign/
    ├── ModelDesign.xml             — OPC UA 信息模型源文件
    ├── BuildDesign.bat             — Model Compiler 构建脚本
    ├── Quickstarts.FakraOpc.Classes.cs       — 生成的 C# 节点类
    ├── Quickstarts.FakraOpc.Constants.cs     — 生成的节点 ID 与浏览名常量
    ├── Quickstarts.FakraOpc.NodeSet2.xml     — 生成的 UANodeSet
    └── Quickstarts.FakraOpc.PredefinedNodes.uanodes — 二进制预定义节点
```

## 环境要求

- .NET 8.0 SDK
- SQL Server（可选，用于作业持久化；未连接时不影响 OPC UA 核心功能）
- OPC UA Model Compiler（用于重新生成信息模型）

## 配置

### OPC UA 端点

在 `FakraOpcServer.Config.xml` 中配置：

| 协议 | URL | 安全策略 |
|---|---|---|
| OPC TCP | `opc.tcp://localhost:62546/OpcUaServer` | None / Sign / SignAndEncrypt |
| HTTPS | `https://localhost:62545/OpcUaServer/` | Basic256Sha256 |

### 数据库

连接字符串在 `FakraOpcMachineState.cs` 中配置。服务器使用 SQL Server，通过 `TB_WorkOrderManagement` 表进行作业持久化。数据库操作为非关键路径——即使数据库不可用，AddJob/DeleteJob 等 OPC UA 方法仍会正常工作（仅 OPC UA 地址空间操作），数据库错误会记录到控制台日志。

## 构建与运行

```bash
dotnet build
dotnet run
```

## 重新生成信息模型

修改 `ModelDesign/ModelDesign.xml` 后，使用以下命令重新生成派生文件：

```bash
cd ModelDesign
Opc.Ua.ModelCompiler.exe compile -version v104 -d2 ".\ModelDesign.xml" -cg ".\ModelDesign.csv" -o2 .\
```

## 依赖项

| 包名 | 版本 | 用途 |
|---|---|---|
| OPCFoundation.NetStandard.Opc.Ua | 1.5.378.106 | OPC UA 服务器 SDK |
| SqlSugarCore | 5.1.4.193 | SQL Server ORM |

---

## 更新日志 v20260324

本次更新全面重构了 OPC UA 方法实现和 REST API 事件触发逻辑，使其完整符合 DiIT CAO 接口规范 v1.3。以下是与旧版本的详细对比。

### 1. AddJob 方法实现（FakraOpcMachineState.cs）

**旧版本：** 仅将作业数据写入 SQL Server 数据库，JobId 由数据库自增主键生成。如果数据库不可用，直接返回 `BadInternalError`，MES 收到错误。未在 OPC UA 地址空间中创建任何节点。

**新版本：** AddJob 现在执行完整的 OPC UA 地址空间操作：
- 验证输入参数（空值返回 `BadArgumentsMissing`，无效 ArticleId 返回 `BadNoMatch`）
- 由服务器通过 `AllocateJobId()` 分配唯一 JobId（内存递增计数器）
- 在 `JobList` 下创建 `JobInfoState` 实例节点，包含所有属性（JobId, JobName, JobQuantity, BatchQuantity, ArticleId, GoodPartCount=0, BadPartCount=0, BatchCount=0, JobState=Initial）
- 数据库写入降级为非关键操作——失败仅记录日志，不影响 OPC UA 方法返回

### 2. ActivateJob 方法实现（FakraOpcMachineState.cs）

**旧版本：** 空实现，直接返回 `ServiceResult.Good`，未执行任何操作。

**新版本：**
- 根据 JobId 查找 Job 节点（不存在则返回 `BadNotFound`）
- 更新 Job 节点：`JobState` → `Active(1)`，设置 `ActivationTime`
- 更新 Machine 节点：`ActiveJobState` → `Active(1)`
- **[Code Review 修复]** 更新 `ProductionStatus` → `JobNotRunning(4)`，符合规范 8.1 节状态转换图
- 内部记录 `m_activeJobId`，供事件触发使用

### 3. DeleteJob 方法实现（FakraOpcMachineState.cs）

**旧版本：** 仅从数据库删除记录，未操作 OPC UA 地址空间。

**新版本：**
- 从地址空间移除 Job 节点及其所有子节点（属性节点）
- **[Code Review 修复]** 如果删除的是当前 active job，重置 `m_activeJobId=0`、`ActiveJobState=Initial(0)`、`ProductionStatus=JobNotActivated(3)`
- 数据库删除降级为非关键操作

### 4. 事件触发 REST API（KomaxController.cs）

**旧版本：** 所有事件的 `JobId` 来自 HTTP 请求体。机器控制器传入的 JobId 与 MES 通过 AddJob 获得的 JobId 是两套独立的 ID 体系。导致 MES 报错 `eventArgs.JobId N != state.TransferLineState.CurrentJobID M => ignored`。

**新版本：** 所有事件端点自动从 `Machine.ActiveJobId` 获取服务器分配的 JobId，确保与 MES 跟踪的 ID 一致：

| 事件 | 旧行为 | 新行为 |
|---|---|---|
| 所有事件 | JobId 来自 HTTP 请求体 | JobId 自动来自 ActiveJobId |
| 无 active job | 不检查，直接触发 | 返回错误 `"No active job"` |
| WireFinished | 仅触发事件 | 触发事件 + 更新 Job 计数器 |
| BatchFinished | 仅触发事件 | 触发事件 + 更新 Job 计数器及 BatchCount |
| JobFinished | 仅触发事件 | 触发事件 + 更新计数器 + `JobState=Finished(2)` |
| JobStopped | 仅触发事件 | 触发事件 + 更新计数器 + `JobState=Stopped(3)` |
| ProductionStarted | 仅触发事件 | 触发事件 + `ProductionStatus=InProduction(6)` |
| ProductionStopped | 仅触发事件 | 触发事件 + 更新计数器 + `ProductionStatus=JobNotRunning(4)` |

新增 `GET /Komax/ActiveJob` 端点，可查询当前活动作业的完整状态。

### 5. 地址空间管理（FakraOpcNodeManager.cs）

**旧版本：** 仅有 `AddArticle` 方法，无 Job 节点管理能力。

**新版本：** 新增以下方法：

| 方法 | 功能 |
|---|---|
| `AddJob()` | 在 JobList 下创建 JobInfoState 节点 |
| `FindJob()` | 按 JobId 查找 Job 节点 |
| `RemoveJob()` | 移除 Job 节点及其子节点 |
| `ArticleExists()` | 验证 ArticleId 是否存在 |
| `Machine` 属性 | 公开 MachineState 供外部访问 |

**[Code Review 修复]** `AddArticle` 改用父构造函数模式（`new ArticleState(articleList)`），与 `AddJob` 保持一致，移除手动双向引用添加，避免潜在的节点重复问题。

### 6. 状态初始化（FakraOpcMachineState.cs）

**旧版本：** Machine 创建后未设置初始状态值。

**新版本：** `OnAfterCreate` 中初始化：
- `ProductionStatus = MachineNotStarted(2)`
- `ActiveJobState = Initial(0)`

### 7. Code Review 发现的其他注意事项

| 项目 | 状态 | 说明 |
|---|---|---|
| GenerateReport | 占位实现 | 返回 Good 但未生成报告文件（TODO） |
| JobId 持久性 | 已知限制 | 内存计数器，服务器重启后从 1 开始。如需持久化应从数据库加载最大值 |
| 连接字符串 | 硬编码 | 建议迁移到 `appsettings.json` 配置文件 |
| REST API 模型 | 冗余字段 | `EventParam.JobId` 不再被事件端点使用（由服务器自动填充），保留是为了向后兼容 |
