#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1515 // Types can be made internal

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
        public const string ActivateJob = "ActivateJob";
        /// <remarks />
        public const string ActivationTime = "ActivationTime";
        /// <remarks />
        public const string ActiveJobState = "ActiveJobState";
        /// <remarks />
        public const string AddJob = "AddJob";
        /// <remarks />
        public const string ArticleId = "ArticleId";
        /// <remarks />
        public const string ArticleList = "ArticleList";
        /// <remarks />
        public const string ArticleListType = "ArticleListType";
        /// <remarks />
        public const string ArticleName = "ArticleName";
        /// <remarks />
        public const string ArticleNumber = "ArticleNumber";
        /// <remarks />
        public const string ArticleType = "ArticleType";
        /// <remarks />
        public const string BadPartCount = "BadPartCount";
        /// <remarks />
        public const string BatchCount = "BatchCount";
        /// <remarks />
        public const string BatchFinishedEventType = "BatchFinishedEventType";
        /// <remarks />
        public const string BatchQuantity = "BatchQuantity";
        /// <remarks />
        public const string BatchSequenceNumber = "BatchSequenceNumber";
        /// <remarks />
        public const string CanBeProduced = "CanBeProduced";
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
        public const string JobInfoType = "JobInfoType";
        /// <remarks />
        public const string JobList = "JobList";
        /// <remarks />
        public const string JobListType = "JobListType";
        /// <remarks />
        public const string JobName = "JobName";
        /// <remarks />
        public const string JobQuantity = "JobQuantity";
        /// <remarks />
        public const string JobState = "JobState";
        /// <remarks />
        public const string JobStoppedEventType = "JobStoppedEventType";
        /// <remarks />
        public const string Machine = "Machine";
        /// <remarks />
        public const string ProductionStartedEventType = "ProductionStartedEventType";
        /// <remarks />
        public const string ProductionStatus = "ProductionStatus";
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
        public const string Machine_AddJob = "nsu=" + Namespaces.Uri + ";s=AddJob";
        /// <remarks />
        public const string Machine_ActivateJob = "nsu=" + Namespaces.Uri + ";i=70";
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

            return value?.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Object nodes.
    /// </summary>
    public static class ObjectIds {
        /// <remarks />
        public const string Machine_JobList = "nsu=" + Namespaces.Uri + ";i=68";
        /// <remarks />
        public const string Machine_ArticleList = "nsu=" + Namespaces.Uri + ";i=69";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value?.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for ObjectType nodes.
    /// </summary>
    public static class ObjectTypeIds {
        /// <remarks />
        public const string ArticleType = "nsu=" + Namespaces.Uri + ";i=48";
        /// <remarks />
        public const string JobInfoType = "nsu=" + Namespaces.Uri + ";i=72";
        /// <remarks />
        public const string JobListType = "nsu=" + Namespaces.Uri + ";i=64";
        /// <remarks />
        public const string ArticleListType = "nsu=" + Namespaces.Uri + ";i=65";
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

            return value?.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Variable nodes.
    /// </summary>
    public static class VariableIds {
        /// <remarks />
        public const string ArticleType_ArticleId = "nsu=" + Namespaces.Uri + ";i=49";
        /// <remarks />
        public const string ArticleType_ArticleName = "nsu=" + Namespaces.Uri + ";i=50";
        /// <remarks />
        public const string ArticleType_ArticleNumber = "nsu=" + Namespaces.Uri + ";i=51";
        /// <remarks />
        public const string ArticleType_CanBeProduced = "nsu=" + Namespaces.Uri + ";i=52";
        /// <remarks />
        public const string JobInfoType_JobId = "nsu=" + Namespaces.Uri + ";i=73";
        /// <remarks />
        public const string JobInfoType_JobName = "nsu=" + Namespaces.Uri + ";i=74";
        /// <remarks />
        public const string JobInfoType_JobQuantity = "nsu=" + Namespaces.Uri + ";i=75";
        /// <remarks />
        public const string JobInfoType_GoodPartCount = "nsu=" + Namespaces.Uri + ";i=76";
        /// <remarks />
        public const string JobInfoType_BadPartCount = "nsu=" + Namespaces.Uri + ";i=77";
        /// <remarks />
        public const string JobInfoType_BatchQuantity = "nsu=" + Namespaces.Uri + ";i=78";
        /// <remarks />
        public const string JobInfoType_BatchCount = "nsu=" + Namespaces.Uri + ";i=79";
        /// <remarks />
        public const string JobInfoType_ArticleId = "nsu=" + Namespaces.Uri + ";i=80";
        /// <remarks />
        public const string JobInfoType_JobState = "nsu=" + Namespaces.Uri + ";i=81";
        /// <remarks />
        public const string JobInfoType_ActivationTime = "nsu=" + Namespaces.Uri + ";i=82";
        /// <remarks />
        public const string Machine_ProductionStatus = "nsu=" + Namespaces.Uri + ";i=66";
        /// <remarks />
        public const string Machine_ActiveJobState = "nsu=" + Namespaces.Uri + ";i=67";
        /// <remarks />
        public const string Machine_AddJob_InputArguments = "nsu=" + Namespaces.Uri + ";i=6";
        /// <remarks />
        public const string Machine_AddJob_OutputArguments = "nsu=" + Namespaces.Uri + ";i=7";
        /// <remarks />
        public const string Machine_ActivateJob_InputArguments = "nsu=" + Namespaces.Uri + ";i=71";
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

            return value?.ToString();
        }
    }
    
}