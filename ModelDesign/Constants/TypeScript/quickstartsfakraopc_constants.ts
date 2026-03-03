export const NS = 'http://schleuniger.com/Default/';

export class BrowseNames {
   static readonly AddJob: string = 'AddJob'
   static readonly BadPartCount: string = 'BadPartCount'
   static readonly BatchFinishedEventType: string = 'BatchFinishedEventType'
   static readonly BatchSequenceNumber: string = 'BatchSequenceNumber'
   static readonly CycleId: string = 'CycleId'
   static readonly DeleteJob: string = 'DeleteJob'
   static readonly GenerateReport: string = 'GenerateReport'
   static readonly GoodPartCount: string = 'GoodPartCount'
   static readonly JobFinishedEventType: string = 'JobFinishedEventType'
   static readonly JobId: string = 'JobId'
   static readonly JobStoppedEventType: string = 'JobStoppedEventType'
   static readonly Machine: string = 'Machine'
   static readonly ProductionStartedEventType: string = 'ProductionStartedEventType'
   static readonly ProductionStoppedEventType: string = 'ProductionStoppedEventType'
   static readonly SystemCycleStatusEventType: string = 'SystemCycleStatusEventType'
   static readonly WireFinishedEventType: string = 'WireFinishedEventType'
   static readonly WireSequenceNumber: string = 'WireSequenceNumber'
}

export class MethodIds {
    static readonly Machine_DeleteJob: string = 'nsu=' + NS + ';i=2'
    static readonly Machine_GenerateReport: string = 'nsu=' + NS + ';i=9'
}

export class ObjectTypeIds {
    static readonly Machine: string = 'nsu=' + NS + ';s=Machine'
    static readonly SystemCycleStatusEventType: string = 'nsu=' + NS + ';i=12'
    static readonly WireFinishedEventType: string = 'nsu=' + NS + ';i=19'
    static readonly BatchFinishedEventType: string = 'nsu=' + NS + ';i=3048'
    static readonly JobFinishedEventType: string = 'nsu=' + NS + ';i=30'
    static readonly JobStoppedEventType: string = 'nsu=' + NS + ';i=34'
    static readonly ProductionStartedEventType: string = 'nsu=' + NS + ';i=38'
    static readonly ProductionStoppedEventType: string = 'nsu=' + NS + ';i=42'
}

export class VariableIds {
    static readonly Machine_AddJob_InputArguments: string = 'nsu=' + NS + ';i=6'
    static readonly Machine_AddJob_OutputArguments: string = 'nsu=' + NS + ';i=7'
    static readonly Machine_DeleteJob_InputArguments: string = 'nsu=' + NS + ';i=3'
    static readonly Machine_GenerateReport_InputArguments: string = 'nsu=' + NS + ';i=10'
    static readonly Machine_GenerateReport_OutputArguments: string = 'nsu=' + NS + ';i=11'
    static readonly SystemCycleStatusEventType_CycleId: string = 'nsu=' + NS + ';i=13'
    static readonly WireFinishedEventType_JobId: string = 'nsu=' + NS + ';i=20'
    static readonly WireFinishedEventType_BatchSequenceNumber: string = 'nsu=' + NS + ';i=21'
    static readonly WireFinishedEventType_WireSequenceNumber: string = 'nsu=' + NS + ';i=22'
    static readonly WireFinishedEventType_GoodPartCount: string = 'nsu=' + NS + ';i=23'
    static readonly WireFinishedEventType_BadPartCount: string = 'nsu=' + NS + ';i=24'
    static readonly BatchFinishedEventType_BatchSequenceNumber: string = 'nsu=' + NS + ';i=4'
    static readonly BatchFinishedEventType_JobId: string = 'nsu=' + NS + ';i=5'
    static readonly BatchFinishedEventType_GoodPartCount: string = 'nsu=' + NS + ';i=25'
    static readonly BatchFinishedEventType_BadPartCount: string = 'nsu=' + NS + ';i=26'
    static readonly JobFinishedEventType_JobId: string = 'nsu=' + NS + ';i=31'
    static readonly JobFinishedEventType_GoodPartCount: string = 'nsu=' + NS + ';i=32'
    static readonly JobFinishedEventType_BadPartCount: string = 'nsu=' + NS + ';i=33'
    static readonly JobStoppedEventType_JobId: string = 'nsu=' + NS + ';i=35'
    static readonly JobStoppedEventType_GoodPartCount: string = 'nsu=' + NS + ';i=36'
    static readonly JobStoppedEventType_BadPartCount: string = 'nsu=' + NS + ';i=37'
    static readonly ProductionStartedEventType_JobId: string = 'nsu=' + NS + ';i=39'
    static readonly ProductionStartedEventType_GoodPartCount: string = 'nsu=' + NS + ';i=40'
    static readonly ProductionStartedEventType_BadPartCount: string = 'nsu=' + NS + ';i=41'
    static readonly ProductionStoppedEventType_JobId: string = 'nsu=' + NS + ';i=43'
    static readonly ProductionStoppedEventType_GoodPartCount: string = 'nsu=' + NS + ';i=44'
    static readonly ProductionStoppedEventType_BadPartCount: string = 'nsu=' + NS + ';i=45'
}
