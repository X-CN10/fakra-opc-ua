namespace Quickstarts.FakraOpc.WebApi
{
    /// <summary>
    /// The namespaces used in the model.
    /// </summary>
    public static class Namespaces
    {
        /// <remarks />
        public const string Uri = "http://schleuniger.com/Default/";
    }

    /// <summary>
    /// The browse names defined in the model.
    /// </summary>
    public static class BrowseNames
    {
        /// <remarks />
        public const string AddJob = "AddJob";
        /// <remarks />
        public const string BadPartCount = "BadPartCount";
        /// <remarks />
        public const string BatchFinishedEventType = "BatchFinishedEventType";
        /// <remarks />
        public const string BatchSequenceNumber = "BatchSequenceNumber";
        /// <remarks />
        public const string CycleId = "CycleId";
        /// <remarks />
        public const string DeleteJob = "DeleteJob";
        /// <remarks />
        public const string GenerateReport = "GenerateReport";
        /// <remarks />
        public const string GoodPartCount = "GoodPartCount";
        /// <remarks />
        public const string JobFinishedEventType = "JobFinishedEventType";
        /// <remarks />
        public const string JobId = "JobId";
        /// <remarks />
        public const string JobStoppedEventType = "JobStoppedEventType";
        /// <remarks />
        public const string Machine = "Machine";
        /// <remarks />
        public const string ProductionStartedEventType = "ProductionStartedEventType";
        /// <remarks />
        public const string ProductionStoppedEventType = "ProductionStoppedEventType";
        /// <remarks />
        public const string SystemCycleStatusEventType = "SystemCycleStatusEventType";
        /// <remarks />
        public const string WireFinishedEventType = "WireFinishedEventType";
        /// <remarks />
        public const string WireSequenceNumber = "WireSequenceNumber";
    }

    /// <summary>
    /// The well known identifiers for Method nodes.
    /// </summary>
    public static class MethodIds {
        /// <remarks />
        public const string Machine_DeleteJob = "nsu=" + Namespaces.Uri + ";i=2";
        /// <remarks />
        public const string Machine_GenerateReport = "nsu=" + Namespaces.Uri + ";i=9";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(MethodIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for ObjectType nodes.
    /// </summary>
    public static class ObjectTypeIds {
        /// <remarks />
        public const string Machine = "nsu=" + Namespaces.Uri + ";s=Machine";
        /// <remarks />
        public const string SystemCycleStatusEventType = "nsu=" + Namespaces.Uri + ";i=12";
        /// <remarks />
        public const string WireFinishedEventType = "nsu=" + Namespaces.Uri + ";i=19";
        /// <remarks />
        public const string BatchFinishedEventType = "nsu=" + Namespaces.Uri + ";i=3048";
        /// <remarks />
        public const string JobFinishedEventType = "nsu=" + Namespaces.Uri + ";i=30";
        /// <remarks />
        public const string JobStoppedEventType = "nsu=" + Namespaces.Uri + ";i=34";
        /// <remarks />
        public const string ProductionStartedEventType = "nsu=" + Namespaces.Uri + ";i=38";
        /// <remarks />
        public const string ProductionStoppedEventType = "nsu=" + Namespaces.Uri + ";i=42";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Variable nodes.
    /// </summary>
    public static class VariableIds {
        /// <remarks />
        public const string Machine_AddJob_InputArguments = "nsu=" + Namespaces.Uri + ";i=6";
        /// <remarks />
        public const string Machine_AddJob_OutputArguments = "nsu=" + Namespaces.Uri + ";i=7";
        /// <remarks />
        public const string Machine_DeleteJob_InputArguments = "nsu=" + Namespaces.Uri + ";i=3";
        /// <remarks />
        public const string Machine_GenerateReport_InputArguments = "nsu=" + Namespaces.Uri + ";i=10";
        /// <remarks />
        public const string Machine_GenerateReport_OutputArguments = "nsu=" + Namespaces.Uri + ";i=11";
        /// <remarks />
        public const string SystemCycleStatusEventType_CycleId = "nsu=" + Namespaces.Uri + ";i=13";
        /// <remarks />
        public const string WireFinishedEventType_JobId = "nsu=" + Namespaces.Uri + ";i=20";
        /// <remarks />
        public const string WireFinishedEventType_BatchSequenceNumber = "nsu=" + Namespaces.Uri + ";i=21";
        /// <remarks />
        public const string WireFinishedEventType_WireSequenceNumber = "nsu=" + Namespaces.Uri + ";i=22";
        /// <remarks />
        public const string WireFinishedEventType_GoodPartCount = "nsu=" + Namespaces.Uri + ";i=23";
        /// <remarks />
        public const string WireFinishedEventType_BadPartCount = "nsu=" + Namespaces.Uri + ";i=24";
        /// <remarks />
        public const string BatchFinishedEventType_BatchSequenceNumber = "nsu=" + Namespaces.Uri + ";i=4";
        /// <remarks />
        public const string BatchFinishedEventType_JobId = "nsu=" + Namespaces.Uri + ";i=5";
        /// <remarks />
        public const string BatchFinishedEventType_GoodPartCount = "nsu=" + Namespaces.Uri + ";i=25";
        /// <remarks />
        public const string BatchFinishedEventType_BadPartCount = "nsu=" + Namespaces.Uri + ";i=26";
        /// <remarks />
        public const string JobFinishedEventType_JobId = "nsu=" + Namespaces.Uri + ";i=31";
        /// <remarks />
        public const string JobFinishedEventType_GoodPartCount = "nsu=" + Namespaces.Uri + ";i=32";
        /// <remarks />
        public const string JobFinishedEventType_BadPartCount = "nsu=" + Namespaces.Uri + ";i=33";
        /// <remarks />
        public const string JobStoppedEventType_JobId = "nsu=" + Namespaces.Uri + ";i=35";
        /// <remarks />
        public const string JobStoppedEventType_GoodPartCount = "nsu=" + Namespaces.Uri + ";i=36";
        /// <remarks />
        public const string JobStoppedEventType_BadPartCount = "nsu=" + Namespaces.Uri + ";i=37";
        /// <remarks />
        public const string ProductionStartedEventType_JobId = "nsu=" + Namespaces.Uri + ";i=39";
        /// <remarks />
        public const string ProductionStartedEventType_GoodPartCount = "nsu=" + Namespaces.Uri + ";i=40";
        /// <remarks />
        public const string ProductionStartedEventType_BadPartCount = "nsu=" + Namespaces.Uri + ";i=41";
        /// <remarks />
        public const string ProductionStoppedEventType_JobId = "nsu=" + Namespaces.Uri + ";i=43";
        /// <remarks />
        public const string ProductionStoppedEventType_GoodPartCount = "nsu=" + Namespaces.Uri + ";i=44";
        /// <remarks />
        public const string ProductionStoppedEventType_BadPartCount = "nsu=" + Namespaces.Uri + ";i=45";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(VariableIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }
    
}