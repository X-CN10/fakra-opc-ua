/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1707 // Identifiers should not contain underscores

namespace Quickstarts.FakraOpc
{
    #region Method Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Methods
    {
        public const string Machine_AddJob = "AddJob";

        public const uint Machine_ActivateJob = 70;

        public const uint Machine_DeleteJob = 2;

        public const uint Machine_GenerateReport = 9;
    }
    #endregion

    #region Object Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Objects
    {
        public const uint Machine_JobList = 68;

        public const uint Machine_ArticleList = 69;
    }
    #endregion

    #region ObjectType Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectTypes
    {
        public const uint ArticleType = 48;

        public const uint JobInfoType = 72;

        public const uint JobListType = 64;

        public const uint ArticleListType = 65;

        public const string Machine = "Machine";

        public const uint SystemCycleStatusEventType = 12;

        public const uint WireFinishedEventType = 19;

        public const uint BatchFinishedEventType = 3048;

        public const uint JobFinishedEventType = 30;

        public const uint JobStoppedEventType = 34;

        public const uint ProductionStartedEventType = 38;

        public const uint ProductionStoppedEventType = 42;
    }
    #endregion

    #region Variable Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Variables
    {
        public const uint ArticleType_ArticleId = 49;

        public const uint ArticleType_ArticleName = 50;

        public const uint ArticleType_ArticleNumber = 51;

        public const uint ArticleType_CanBeProduced = 52;

        public const uint JobInfoType_JobId = 73;

        public const uint JobInfoType_JobName = 74;

        public const uint JobInfoType_JobQuantity = 75;

        public const uint JobInfoType_GoodPartCount = 76;

        public const uint JobInfoType_BadPartCount = 77;

        public const uint JobInfoType_BatchQuantity = 78;

        public const uint JobInfoType_BatchCount = 79;

        public const uint JobInfoType_ArticleId = 80;

        public const uint JobInfoType_JobState = 81;

        public const uint JobInfoType_ActivationTime = 82;

        public const uint Machine_ProductionStatus = 66;

        public const uint Machine_ActiveJobState = 67;

        public const uint Machine_AddJob_InputArguments = 6;

        public const uint Machine_AddJob_OutputArguments = 7;

        public const uint Machine_ActivateJob_InputArguments = 71;

        public const uint Machine_DeleteJob_InputArguments = 3;

        public const uint Machine_GenerateReport_InputArguments = 10;

        public const uint Machine_GenerateReport_OutputArguments = 11;

        public const uint SystemCycleStatusEventType_CycleId = 13;

        public const uint WireFinishedEventType_JobId = 20;

        public const uint WireFinishedEventType_BatchSequenceNumber = 21;

        public const uint WireFinishedEventType_WireSequenceNumber = 22;

        public const uint WireFinishedEventType_GoodPartCount = 23;

        public const uint WireFinishedEventType_BadPartCount = 24;

        public const uint BatchFinishedEventType_BatchSequenceNumber = 4;

        public const uint BatchFinishedEventType_JobId = 5;

        public const uint BatchFinishedEventType_GoodPartCount = 25;

        public const uint BatchFinishedEventType_BadPartCount = 26;

        public const uint JobFinishedEventType_JobId = 31;

        public const uint JobFinishedEventType_GoodPartCount = 32;

        public const uint JobFinishedEventType_BadPartCount = 33;

        public const uint JobStoppedEventType_JobId = 35;

        public const uint JobStoppedEventType_GoodPartCount = 36;

        public const uint JobStoppedEventType_BadPartCount = 37;

        public const uint ProductionStartedEventType_JobId = 39;

        public const uint ProductionStartedEventType_GoodPartCount = 40;

        public const uint ProductionStartedEventType_BadPartCount = 41;

        public const uint ProductionStoppedEventType_JobId = 43;

        public const uint ProductionStoppedEventType_GoodPartCount = 44;

        public const uint ProductionStoppedEventType_BadPartCount = 45;
    }
    #endregion

    #region Method Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class MethodIds
    {
        public static readonly ExpandedNodeId Machine_AddJob = new ExpandedNodeId(Quickstarts.FakraOpc.Methods.Machine_AddJob, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_ActivateJob = new ExpandedNodeId(Quickstarts.FakraOpc.Methods.Machine_ActivateJob, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_DeleteJob = new ExpandedNodeId(Quickstarts.FakraOpc.Methods.Machine_DeleteJob, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_GenerateReport = new ExpandedNodeId(Quickstarts.FakraOpc.Methods.Machine_GenerateReport, Quickstarts.FakraOpc.Namespaces.FakraOpc);
    }
    #endregion

    #region Object Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectIds
    {
        public static readonly ExpandedNodeId Machine_JobList = new ExpandedNodeId(Quickstarts.FakraOpc.Objects.Machine_JobList, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_ArticleList = new ExpandedNodeId(Quickstarts.FakraOpc.Objects.Machine_ArticleList, Quickstarts.FakraOpc.Namespaces.FakraOpc);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectTypeIds
    {
        public static readonly ExpandedNodeId ArticleType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.ArticleType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.JobInfoType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobListType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.JobListType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ArticleListType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.ArticleListType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.Machine, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId SystemCycleStatusEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.SystemCycleStatusEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId WireFinishedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.WireFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId BatchFinishedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.BatchFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobFinishedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.JobFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobStoppedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.JobStoppedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ProductionStartedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.ProductionStartedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ProductionStoppedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.ProductionStoppedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);
    }
    #endregion

    #region Variable Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class VariableIds
    {
        public static readonly ExpandedNodeId ArticleType_ArticleId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ArticleType_ArticleId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ArticleType_ArticleName = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ArticleType_ArticleName, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ArticleType_ArticleNumber = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ArticleType_ArticleNumber, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ArticleType_CanBeProduced = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ArticleType_CanBeProduced, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_JobName = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_JobName, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_JobQuantity = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_JobQuantity, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_BatchQuantity = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_BatchQuantity, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_BatchCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_BatchCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_ArticleId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_ArticleId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_JobState = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_JobState, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobInfoType_ActivationTime = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobInfoType_ActivationTime, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_ProductionStatus = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_ProductionStatus, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_ActiveJobState = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_ActiveJobState, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_AddJob_InputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_AddJob_InputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_AddJob_OutputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_AddJob_OutputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_ActivateJob_InputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_ActivateJob_InputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_DeleteJob_InputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_DeleteJob_InputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_GenerateReport_InputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_GenerateReport_InputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId Machine_GenerateReport_OutputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_GenerateReport_OutputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId SystemCycleStatusEventType_CycleId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.SystemCycleStatusEventType_CycleId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId WireFinishedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId WireFinishedEventType_BatchSequenceNumber = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_BatchSequenceNumber, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId WireFinishedEventType_WireSequenceNumber = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_WireSequenceNumber, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId WireFinishedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId WireFinishedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId BatchFinishedEventType_BatchSequenceNumber = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.BatchFinishedEventType_BatchSequenceNumber, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId BatchFinishedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.BatchFinishedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId BatchFinishedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.BatchFinishedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId BatchFinishedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.BatchFinishedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobFinishedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobFinishedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobFinishedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobFinishedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobFinishedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobFinishedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobStoppedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobStoppedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobStoppedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobStoppedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId JobStoppedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobStoppedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ProductionStartedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStartedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ProductionStartedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStartedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ProductionStartedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStartedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ProductionStoppedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStoppedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ProductionStoppedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStoppedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        public static readonly ExpandedNodeId ProductionStoppedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStoppedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);
    }
    #endregion

    #region BrowseName Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class BrowseNames
    {
        public const string ActivateJob = "ActivateJob";

        public const string ActivationTime = "ActivationTime";

        public const string ActiveJobState = "ActiveJobState";

        public const string AddJob = "AddJob";

        public const string ArticleId = "ArticleId";

        public const string ArticleList = "ArticleList";

        public const string ArticleListType = "ArticleListType";

        public const string ArticleName = "ArticleName";

        public const string ArticleNumber = "ArticleNumber";

        public const string ArticleType = "ArticleType";

        public const string BadPartCount = "BadPartCount";

        public const string BatchCount = "BatchCount";

        public const string BatchFinishedEventType = "BatchFinishedEventType";

        public const string BatchQuantity = "BatchQuantity";

        public const string BatchSequenceNumber = "BatchSequenceNumber";

        public const string CanBeProduced = "CanBeProduced";

        public const string CycleId = "CycleId";

        public const string DeleteJob = "DeleteJob";

        public const string GenerateReport = "GenerateReport";

        public const string GoodPartCount = "GoodPartCount";

        public const string JobFinishedEventType = "JobFinishedEventType";

        public const string JobId = "JobId";

        public const string JobInfoType = "JobInfoType";

        public const string JobList = "JobList";

        public const string JobListType = "JobListType";

        public const string JobName = "JobName";

        public const string JobQuantity = "JobQuantity";

        public const string JobState = "JobState";

        public const string JobStoppedEventType = "JobStoppedEventType";

        public const string Machine = "Machine";

        public const string ProductionStartedEventType = "ProductionStartedEventType";

        public const string ProductionStatus = "ProductionStatus";

        public const string ProductionStoppedEventType = "ProductionStoppedEventType";

        public const string SystemCycleStatusEventType = "SystemCycleStatusEventType";

        public const string WireFinishedEventType = "WireFinishedEventType";

        public const string WireSequenceNumber = "WireSequenceNumber";
    }
    #endregion

    #region Namespace Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the FakraOpc namespace (.NET code namespace is 'Quickstarts.FakraOpc').
        /// </summary>
        public const string FakraOpc = "http://schleuniger.com/Default/";
    }
    #endregion
}