export const NS = 'http://schleuniger.com/Default/';

export const BrowseNames = Object.freeze({
   AddJob: 'AddJob',
   BadPartCount: 'BadPartCount',
   BatchFinishedEventType: 'BatchFinishedEventType',
   BatchSequenceNumber: 'BatchSequenceNumber',
   CycleId: 'CycleId',
   DeleteJob: 'DeleteJob',
   GenerateReport: 'GenerateReport',
   GoodPartCount: 'GoodPartCount',
   JobFinishedEventType: 'JobFinishedEventType',
   JobId: 'JobId',
   JobStoppedEventType: 'JobStoppedEventType',
   Machine: 'Machine',
   ProductionStartedEventType: 'ProductionStartedEventType',
   ProductionStoppedEventType: 'ProductionStoppedEventType',
   SystemCycleStatusEventType: 'SystemCycleStatusEventType',
   WireFinishedEventType: 'WireFinishedEventType',
   WireSequenceNumber: 'WireSequenceNumber',
});

export const MethodIds = Object.freeze({
   Machine_DeleteJob: 'nsu=' + NS + ';i=2',
   Machine_GenerateReport: 'nsu=' + NS + ';i=9',
});

export const ObjectTypeIds = Object.freeze({
   Machine: 'nsu=' + NS + ';s=Machine',
   SystemCycleStatusEventType: 'nsu=' + NS + ';i=12',
   WireFinishedEventType: 'nsu=' + NS + ';i=19',
   BatchFinishedEventType: 'nsu=' + NS + ';i=3048',
   JobFinishedEventType: 'nsu=' + NS + ';i=30',
   JobStoppedEventType: 'nsu=' + NS + ';i=34',
   ProductionStartedEventType: 'nsu=' + NS + ';i=38',
   ProductionStoppedEventType: 'nsu=' + NS + ';i=42',
});

export const VariableIds = Object.freeze({
   Machine_AddJob_InputArguments: 'nsu=' + NS + ';i=6',
   Machine_AddJob_OutputArguments: 'nsu=' + NS + ';i=7',
   Machine_DeleteJob_InputArguments: 'nsu=' + NS + ';i=3',
   Machine_GenerateReport_InputArguments: 'nsu=' + NS + ';i=10',
   Machine_GenerateReport_OutputArguments: 'nsu=' + NS + ';i=11',
   SystemCycleStatusEventType_CycleId: 'nsu=' + NS + ';i=13',
   WireFinishedEventType_JobId: 'nsu=' + NS + ';i=20',
   WireFinishedEventType_BatchSequenceNumber: 'nsu=' + NS + ';i=21',
   WireFinishedEventType_WireSequenceNumber: 'nsu=' + NS + ';i=22',
   WireFinishedEventType_GoodPartCount: 'nsu=' + NS + ';i=23',
   WireFinishedEventType_BadPartCount: 'nsu=' + NS + ';i=24',
   BatchFinishedEventType_BatchSequenceNumber: 'nsu=' + NS + ';i=4',
   BatchFinishedEventType_JobId: 'nsu=' + NS + ';i=5',
   BatchFinishedEventType_GoodPartCount: 'nsu=' + NS + ';i=25',
   BatchFinishedEventType_BadPartCount: 'nsu=' + NS + ';i=26',
   JobFinishedEventType_JobId: 'nsu=' + NS + ';i=31',
   JobFinishedEventType_GoodPartCount: 'nsu=' + NS + ';i=32',
   JobFinishedEventType_BadPartCount: 'nsu=' + NS + ';i=33',
   JobStoppedEventType_JobId: 'nsu=' + NS + ';i=35',
   JobStoppedEventType_GoodPartCount: 'nsu=' + NS + ';i=36',
   JobStoppedEventType_BadPartCount: 'nsu=' + NS + ';i=37',
   ProductionStartedEventType_JobId: 'nsu=' + NS + ';i=39',
   ProductionStartedEventType_GoodPartCount: 'nsu=' + NS + ';i=40',
   ProductionStartedEventType_BadPartCount: 'nsu=' + NS + ';i=41',
   ProductionStoppedEventType_JobId: 'nsu=' + NS + ';i=43',
   ProductionStoppedEventType_GoodPartCount: 'nsu=' + NS + ';i=44',
   ProductionStoppedEventType_BadPartCount: 'nsu=' + NS + ';i=45',
});
