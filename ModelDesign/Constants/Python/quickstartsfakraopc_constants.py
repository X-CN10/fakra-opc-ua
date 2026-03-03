from enum import Enum

class Namespaces(Enum):
     Uri = "http://schleuniger.com/Default/"

class BrowseNames(Enum):
    ActivateJob = "ActivateJob"
    ActivationTime = "ActivationTime"
    ActiveJobState = "ActiveJobState"
    AddJob = "AddJob"
    ArticleId = "ArticleId"
    ArticleList = "ArticleList"
    ArticleListType = "ArticleListType"
    ArticleName = "ArticleName"
    ArticleNumber = "ArticleNumber"
    ArticleType = "ArticleType"
    BadPartCount = "BadPartCount"
    BatchCount = "BatchCount"
    BatchFinishedEventType = "BatchFinishedEventType"
    BatchQuantity = "BatchQuantity"
    BatchSequenceNumber = "BatchSequenceNumber"
    CanBeProduced = "CanBeProduced"
    CycleId = "CycleId"
    DeleteJob = "DeleteJob"
    GenerateReport = "GenerateReport"
    GoodPartCount = "GoodPartCount"
    JobFinishedEventType = "JobFinishedEventType"
    JobId = "JobId"
    JobInfoType = "JobInfoType"
    JobList = "JobList"
    JobListType = "JobListType"
    JobName = "JobName"
    JobQuantity = "JobQuantity"
    JobState = "JobState"
    JobStoppedEventType = "JobStoppedEventType"
    Machine = "Machine"
    ProductionStartedEventType = "ProductionStartedEventType"
    ProductionStatus = "ProductionStatus"
    ProductionStoppedEventType = "ProductionStoppedEventType"
    SystemCycleStatusEventType = "SystemCycleStatusEventType"
    WireFinishedEventType = "WireFinishedEventType"
    WireSequenceNumber = "WireSequenceNumber"

class MethodIds(Enum):
    Machine_AddJob = "nsu=http://schleuniger.com/Default/;s=AddJob"
    Machine_ActivateJob = "nsu=http://schleuniger.com/Default/;i=70"
    Machine_DeleteJob = "nsu=http://schleuniger.com/Default/;i=2"
    Machine_GenerateReport = "nsu=http://schleuniger.com/Default/;i=9"

def get_MethodIds_name(value: str) -> str:
    try:
        return MethodIds(value).name
    except ValueError:
        return None


class ObjectIds(Enum):
    Machine_JobList = "nsu=http://schleuniger.com/Default/;i=68"
    Machine_ArticleList = "nsu=http://schleuniger.com/Default/;i=69"

def get_ObjectIds_name(value: str) -> str:
    try:
        return ObjectIds(value).name
    except ValueError:
        return None


class ObjectTypeIds(Enum):
    ArticleType = "nsu=http://schleuniger.com/Default/;i=48"
    JobInfoType = "nsu=http://schleuniger.com/Default/;i=72"
    JobListType = "nsu=http://schleuniger.com/Default/;i=64"
    ArticleListType = "nsu=http://schleuniger.com/Default/;i=65"
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
    ArticleType_ArticleId = "nsu=http://schleuniger.com/Default/;i=49"
    ArticleType_ArticleName = "nsu=http://schleuniger.com/Default/;i=50"
    ArticleType_ArticleNumber = "nsu=http://schleuniger.com/Default/;i=51"
    ArticleType_CanBeProduced = "nsu=http://schleuniger.com/Default/;i=52"
    JobInfoType_JobId = "nsu=http://schleuniger.com/Default/;i=73"
    JobInfoType_JobName = "nsu=http://schleuniger.com/Default/;i=74"
    JobInfoType_JobQuantity = "nsu=http://schleuniger.com/Default/;i=75"
    JobInfoType_GoodPartCount = "nsu=http://schleuniger.com/Default/;i=76"
    JobInfoType_BadPartCount = "nsu=http://schleuniger.com/Default/;i=77"
    JobInfoType_BatchQuantity = "nsu=http://schleuniger.com/Default/;i=78"
    JobInfoType_BatchCount = "nsu=http://schleuniger.com/Default/;i=79"
    JobInfoType_ArticleId = "nsu=http://schleuniger.com/Default/;i=80"
    JobInfoType_JobState = "nsu=http://schleuniger.com/Default/;i=81"
    JobInfoType_ActivationTime = "nsu=http://schleuniger.com/Default/;i=82"
    Machine_ProductionStatus = "nsu=http://schleuniger.com/Default/;i=66"
    Machine_ActiveJobState = "nsu=http://schleuniger.com/Default/;i=67"
    Machine_AddJob_InputArguments = "nsu=http://schleuniger.com/Default/;i=6"
    Machine_AddJob_OutputArguments = "nsu=http://schleuniger.com/Default/;i=7"
    Machine_ActivateJob_InputArguments = "nsu=http://schleuniger.com/Default/;i=71"
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

