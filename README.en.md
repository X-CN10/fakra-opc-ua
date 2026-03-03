[English](README.en.md) | [中文](README.md)

# WebApiOpcServer

An OPC UA Server for the Schleuniger TransferLine machine, implementing the DiIT CAO interface specification. Built with ASP.NET Core 8 and the OPC Foundation .NET Standard SDK, the server exposes both an OPC UA endpoint for MES integration and a Web API for machine-side event triggering.

## Architecture

```
┌──────────────┐     OPC UA (opc.tcp)     ┌─────────────────────┐
│  DiIT CAO    │◄────────────────────────►│  WebApiOpcServer     │
│  (MES)       │  Subscribe / Methods      │                     │
└──────────────┘                           │  ┌───────────────┐  │
                                           │  │ OPC UA Server  │  │
┌──────────────┐     HTTP REST API         │  │ (port 62546)   │  │
│  Machine     │─────────────────────────►│  ├───────────────┤  │
│  Controller  │  Trigger Events           │  │ Web API        │  │
└──────────────┘                           │  │ (port 5000)    │  │
                                           │  └───────┬───────┘  │
                                           │          │          │
                                           │  ┌───────▼───────┐  │
                                           │  │  SQL Server    │  │
                                           │  │  (Job Storage) │  │
                                           │  └───────────────┘  │
                                           └─────────────────────┘
```

The server acts as a bridge between the MES system (DiIT CAO) and the physical machine. The MES communicates via OPC UA to manage jobs, read articles, and subscribe to production events. The machine controller triggers events through the REST API.

## Interface Specification

Based on **DiIT CAO - Schleuniger TransferLine - OPC UA Interface Specification v1.3**.

### OPC UA Namespace

| Namespace Index | URI |
|---|---|
| 0 | `http://opcfoundation.org/UA/` |
| 1 (internal) | Server diagnostics |
| 2 | `http://schleuniger.com/Default/` |

### Address Space

```
Objects (i=85)
└── Machine (ns=2;s=Machine)
    ├── ProductionStatus      : Int32 (R)        — ProductionStatusEnum
    ├── ActiveJobState        : Int32 (R)        — JobStateEnum
    ├── JobList               : JobListType       — Container for Job instances
    │   ├── Job_1             : JobInfoType
    │   ├── Job_2             : JobInfoType
    │   └── ...
    ├── ArticleList           : ArticleListType   — Container for Article instances
    │   ├── Article_1         : ArticleType
    │   ├── Article_2         : ArticleType
    │   └── ...
    ├── AddJob()              — Create a new job
    ├── ActivateJob()         — Activate a job for production
    ├── DeleteJob()           — Delete a job
    └── GenerateReport()      — Generate a production report
```

### Object Types

#### MachineType

The root entry point, located under the `Objects` folder. Supports event subscriptions.

| Reference | Child | DataType / TypeDefinition | Access |
|---|---|---|---|
| HasProperty | ProductionStatus | Int32 (ProductionStatusEnum) | Read |
| HasProperty | ActiveJobState | Int32 (JobStateEnum) | Read |
| HasComponent | JobList | JobListType | Read |
| HasComponent | ArticleList | ArticleListType | Read |
| HasComponent | AddJob | Method | — |
| HasComponent | ActivateJob | Method | — |
| HasComponent | DeleteJob | Method | — |
| HasComponent | GenerateReport | Method | — |

#### JobInfoType

| Property | DataType | Access | Description |
|---|---|---|---|
| JobId | UInt32 | Read | Unique ID assigned by server |
| JobName | String | Read | Name assigned by client via AddJob |
| JobQuantity | UInt32 | Read | Total parts to produce |
| GoodPartCount | UInt32 | Read | Current good parts count |
| BadPartCount | UInt32 | Read | Current bad parts count |
| BatchQuantity | UInt32 | Read | Parts per batch |
| BatchCount | UInt32 | Read | Batches produced so far |
| ArticleId | UInt32 | Read | ID of the article being produced |
| JobState | Int32 | Read | Current state (JobStateEnum) |
| ActivationTime | DateTime | Read | Time of job activation (optional) |

#### ArticleType

| Property | DataType | Access | Description |
|---|---|---|---|
| ArticleId | UInt32 | Read | Unique article identifier |
| ArticleName | String | Read | Name of the article |
| ArticleNumber | String | Read | Article number (used by MES to match leadset) |
| CanBeProduced | Boolean | Read | Whether the machine can produce this article |

### Enumerations

#### ProductionStatusEnum

| Name | Value | Description |
|---|---|---|
| MachineNotAvailable | 0 | Machine is off or not connected |
| MachineNotHomed | 1 | Machine is on but not initialized |
| MachineNotStarted | 2 | Machine is on and initialized but not started |
| JobNotActivated | 3 | Machine is running but job not loaded/activated |
| JobNotRunning | 4 | Job is loaded and activated but not started |
| JobRunning | 5 | Job is running, ready to handle parts |
| InProduction | 6 | Parts are inserted, machine is producing |
| AdjustMode | 7 | Machine runs in adjust mode |
| HasError | 8 | Machine is in error state |

#### JobStateEnum

| Name | Value | Description |
|---|---|---|
| Initial | 0 | No active job |
| Active | 1 | Job is active and running |
| Finished | 2 | Job has been finished |
| Stopped | 3 | Job is active but has been stopped |

### Methods

#### AddJob

Creates a new production job.

| Direction | Name | DataType | Description |
|---|---|---|---|
| Input | JobName | String | The job name |
| Input | JobQuantity | UInt32 | Total quantity to produce |
| Input | BatchQuantity | UInt32 | Quantity per batch |
| Input | ArticleId | UInt32 | ID of the article to produce |
| Output | JobId | UInt32 | Assigned unique job ID |

#### ActivateJob

Activates a job for production (downloads recipe, releases machine).

| Direction | Name | DataType | Description |
|---|---|---|---|
| Input | JobId | UInt32 | The job to activate |

#### DeleteJob

Deletes a job from the machine.

| Direction | Name | DataType | Description |
|---|---|---|---|
| Input | JobId | UInt32 | The job to delete |

#### GenerateReport

Generates a production report file (OPC UA FileType).

| Direction | Name | DataType | Description |
|---|---|---|---|
| Input | JobId | UInt32 | The job ID |
| Input | Scope | Int32 | Report scope (0=Job, 1=Batch, 2=Wire) |
| Input | ScopeId | UInt32 | Scope-specific ID |
| Output | ReportFileNode | NodeId | Node ID of the generated report file |

### Event Types

All production event types are direct subtypes of `BaseEventType`.

#### WireFinishedEventType

Raised when a single wire has been produced.

| Property | DataType |
|---|---|
| JobId | UInt32 |
| BatchSequenceNumber | UInt32 |
| WireSequenceNumber | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### BatchFinishedEventType

Raised when a batch of cables has been finished.

| Property | DataType |
|---|---|
| JobId | UInt32 |
| BatchSequenceNumber | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### JobFinishedEventType

Raised when a job has been produced completely.

| Property | DataType |
|---|---|
| JobId | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### JobStoppedEventType

Raised when a job has been stopped prematurely.

| Property | DataType |
|---|---|
| JobId | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### ProductionStartedEventType

Raised when production physically starts.

| Property | DataType |
|---|---|
| JobId | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

#### ProductionStoppedEventType

Raised when production physically stops.

| Property | DataType |
|---|---|
| JobId | UInt32 |
| GoodPartCount | UInt32 |
| BadPartCount | UInt32 |

### Event Sequence (Typical Workflow)

```
ProductionStarted   ← operator inserts cable
WireFinished        ← repeated for each wire
BatchFinished       ← repeated for each batch
JobFinished         ← entire job completed
ProductionStopped   ← machine stops processing
```

## Web API (Machine-Side)

REST endpoints for the machine controller to trigger OPC UA events.

### POST /Komax/ProductionStartedEventTigger

Triggers a `ProductionStartedEvent` on the OPC UA server.

**Request Body:**

```json
{
  "jobId": 1,
  "goodPartCount": 10,
  "badPartCount": 0
}
```

**Response:**

```json
{
  "suscess": true,
  "message": ""
}
```

## Project Structure

```
WebApiOpcServer/
├── Program.cs                      — Application entry point, starts OPC UA + Web API
├── FakraOpcServer.cs               — OPC UA StandardServer implementation
├── FakraOpcNodeManager.cs          — Custom node manager, loads address space
├── FakraOpcNodeManagerFactory.cs   — Factory for the node manager
├── FakraOpcMachineState.cs         — Machine business logic (AddJob, DeleteJob, etc.)
├── FakraOpcServerConfiguration.cs  — Server configuration model
├── FakraOpcServer.Config.xml       — OPC UA application configuration
├── Controllers/
│   ├── KomaxController.cs          — REST API for triggering events
│   └── WeatherForecastController.cs— Test/demo controller
├── Model/
│   ├── Common.cs                   — Shared API models
│   └── TB_WorkOrderManagement.cs   — SQL Server entity for job storage
└── ModelDesign/
    ├── ModelDesign.xml             — OPC UA information model source
    ├── BuildDesign.bat             — Model Compiler build script
    ├── Quickstarts.FakraOpc.Classes.cs       — Generated C# node classes
    ├── Quickstarts.FakraOpc.Constants.cs     — Generated node IDs & browse names
    ├── Quickstarts.FakraOpc.NodeSet2.xml     — Generated UANodeSet
    └── Quickstarts.FakraOpc.PredefinedNodes.uanodes — Binary predefined nodes
```

## Prerequisites

- .NET 8.0 SDK
- SQL Server (for job persistence)
- OPC UA Model Compiler (for regenerating the information model)

## Configuration

### OPC UA Endpoints

Configured in `FakraOpcServer.Config.xml`:

| Protocol | URL | Security |
|---|---|---|
| OPC TCP | `opc.tcp://localhost:62546/OpcUaServer` | None / Sign / SignAndEncrypt |
| HTTPS | `https://localhost:62545/OpcUaServer/` | Basic256Sha256 |

### Database

Connection string is configured in `FakraOpcMachineState.cs`. The server uses SQL Server with the `TB_WorkOrderManagement` table for job persistence.

## Build & Run

```bash
dotnet build
dotnet run
```

## Regenerating the Information Model

When modifying `ModelDesign/ModelDesign.xml`, regenerate derived files using:

```bash
cd ModelDesign
Opc.Ua.ModelCompiler.exe compile -version v104 -d2 ".\ModelDesign.xml" -cg ".\ModelDesign.csv" -o2 .\
```

## Dependencies

| Package | Version | Purpose |
|---|---|---|
| OPCFoundation.NetStandard.Opc.Ua | 1.5.378.106 | OPC UA server SDK |
| SqlSugarCore | 5.1.4.193 | ORM for SQL Server |
