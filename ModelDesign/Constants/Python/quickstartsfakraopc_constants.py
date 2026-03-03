from enum import Enum

class Namespaces(Enum):
     Uri = "http://schleuniger.com/Default/"

class BrowseNames(Enum):
    AddJob = "AddJob"
    BadPartCount = "BadPartCount"
    BatchFinishedEventType = "BatchFinishedEventType"
    BatchSequenceNumber = "BatchSequenceNumber"
    CycleId = "CycleId"
    DeleteJob = "DeleteJob"
    GenerateReport = "GenerateReport"
    GoodPartCount = "GoodPartCount"
    JobFinishedEventType = "JobFinishedEventType"
    JobId = "JobId"
    JobStoppedEventType = "JobStoppedEventType"
    Machine = "Machine"
    ProductionStartedEventType = "ProductionStartedEventType"
    ProductionStoppedEventType = "ProductionStoppedEventType"
    SystemCycleStatusEventType = "SystemCycleStatusEventType"
    WireFinishedEventType = "WireFinishedEventType"
    WireSequenceNumber = "WireSequenceNumber"

class MethodIds(Enum):
    Machine_DeleteJob = "nsu=http://schleuniger.com/Default/;i=2"
    Machine_GenerateReport = "nsu=http://schleuniger.com/Default/;i=9"

def get_MethodIds_name(value: str) -> str:
    try:
        return MethodIds(value).name
    except ValueError:
        return None


class ObjectTypeIds(Enum):
    Machine = "nsu=http://schleuniger.com/Default/;s=Machine"
    SystemCycleStatusEventType = "nsu=http://schleuniger.com/Default/;i=12"
    WireFinishedEventType = "nsu=http://schleuniger.com/Default/;i=19"
    BatchFinishedEventType = "nsu=http://schleuniger.com/Default/;i=3048"
    JobFinishedEventType = "nsu=http://schleuniger.com/Default/;i=30"
    JobStoppedEventType = "nsu=http://schleuniger.com/Default/;i=34"
    ProductionStartedEventType = "nsu=http://schleuniger.com/Default/;i=38"
    ProductionStoppedEventType = "nsu=http://schleuniger.com/Default/;i=42"

def get_ObjectTypeIds_name(value: str) -> str:
    try:
        return ObjectTypeIds(value).name
    except ValueError:
        return None


class VariableIds(Enum):
    Machine_AddJob_InputArguments = "nsu=http://schleuniger.com/Default/;i=6"
    Machine_AddJob_OutputArguments = "nsu=http://schleuniger.com/Default/;i=7"
    Machine_DeleteJob_InputArguments = "nsu=http://schleuniger.com/Default/;i=3"
    Machine_GenerateReport_InputArguments = "nsu=http://schleuniger.com/Default/;i=10"
    Machine_GenerateReport_OutputArguments = "nsu=http://schleuniger.com/Default/;i=11"
    SystemCycleStatusEventType_CycleId = "nsu=http://schleuniger.com/Default/;i=13"
    WireFinishedEventType_JobId = "nsu=http://schleuniger.com/Default/;i=20"
    WireFinishedEventType_BatchSequenceNumber = "nsu=http://schleuniger.com/Default/;i=21"
    WireFinishedEventType_WireSequenceNumber = "nsu=http://schleuniger.com/Default/;i=22"
    WireFinishedEventType_GoodPartCount = "nsu=http://schleuniger.com/Default/;i=23"
    WireFinishedEventType_BadPartCount = "nsu=http://schleuniger.com/Default/;i=24"
    BatchFinishedEventType_BatchSequenceNumber = "nsu=http://schleuniger.com/Default/;i=4"
    BatchFinishedEventType_JobId = "nsu=http://schleuniger.com/Default/;i=5"
    BatchFinishedEventType_GoodPartCount = "nsu=http://schleuniger.com/Default/;i=25"
    BatchFinishedEventType_BadPartCount = "nsu=http://schleuniger.com/Default/;i=26"
    JobFinishedEventType_JobId = "nsu=http://schleuniger.com/Default/;i=31"
    JobFinishedEventType_GoodPartCount = "nsu=http://schleuniger.com/Default/;i=32"
    JobFinishedEventType_BadPartCount = "nsu=http://schleuniger.com/Default/;i=33"
    JobStoppedEventType_JobId = "nsu=http://schleuniger.com/Default/;i=35"
    JobStoppedEventType_GoodPartCount = "nsu=http://schleuniger.com/Default/;i=36"
    JobStoppedEventType_BadPartCount = "nsu=http://schleuniger.com/Default/;i=37"
    ProductionStartedEventType_JobId = "nsu=http://schleuniger.com/Default/;i=39"
    ProductionStartedEventType_GoodPartCount = "nsu=http://schleuniger.com/Default/;i=40"
    ProductionStartedEventType_BadPartCount = "nsu=http://schleuniger.com/Default/;i=41"
    ProductionStoppedEventType_JobId = "nsu=http://schleuniger.com/Default/;i=43"
    ProductionStoppedEventType_GoodPartCount = "nsu=http://schleuniger.com/Default/;i=44"
    ProductionStoppedEventType_BadPartCount = "nsu=http://schleuniger.com/Default/;i=45"

def get_VariableIds_name(value: str) -> str:
    try:
        return VariableIds(value).name
    except ValueError:
        return None

