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

namespace Quickstarts.FakraOpc
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint Machine_DeleteJob = 2;

        /// <remarks />
        public const uint Machine_GenerateReport = 9;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const string Machine = "Machine";

        /// <remarks />
        public const uint SystemCycleStatusEventType = 12;

        /// <remarks />
        public const uint WireFinishedEventType = 19;

        /// <remarks />
        public const uint BatchFinishedEventType = 3048;

        /// <remarks />
        public const uint JobFinishedEventType = 30;

        /// <remarks />
        public const uint JobStoppedEventType = 34;

        /// <remarks />
        public const uint ProductionStartedEventType = 38;

        /// <remarks />
        public const uint ProductionStoppedEventType = 42;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint Machine_AddJob_InputArguments = 6;

        /// <remarks />
        public const uint Machine_AddJob_OutputArguments = 7;

        /// <remarks />
        public const uint Machine_DeleteJob_InputArguments = 3;

        /// <remarks />
        public const uint Machine_GenerateReport_InputArguments = 10;

        /// <remarks />
        public const uint Machine_GenerateReport_OutputArguments = 11;

        /// <remarks />
        public const uint SystemCycleStatusEventType_CycleId = 13;

        /// <remarks />
        public const uint WireFinishedEventType_JobId = 20;

        /// <remarks />
        public const uint WireFinishedEventType_BatchSequenceNumber = 21;

        /// <remarks />
        public const uint WireFinishedEventType_WireSequenceNumber = 22;

        /// <remarks />
        public const uint WireFinishedEventType_GoodPartCount = 23;

        /// <remarks />
        public const uint WireFinishedEventType_BadPartCount = 24;

        /// <remarks />
        public const uint BatchFinishedEventType_BatchSequenceNumber = 4;

        /// <remarks />
        public const uint BatchFinishedEventType_JobId = 5;

        /// <remarks />
        public const uint BatchFinishedEventType_GoodPartCount = 25;

        /// <remarks />
        public const uint BatchFinishedEventType_BadPartCount = 26;

        /// <remarks />
        public const uint JobFinishedEventType_JobId = 31;

        /// <remarks />
        public const uint JobFinishedEventType_GoodPartCount = 32;

        /// <remarks />
        public const uint JobFinishedEventType_BadPartCount = 33;

        /// <remarks />
        public const uint JobStoppedEventType_JobId = 35;

        /// <remarks />
        public const uint JobStoppedEventType_GoodPartCount = 36;

        /// <remarks />
        public const uint JobStoppedEventType_BadPartCount = 37;

        /// <remarks />
        public const uint ProductionStartedEventType_JobId = 39;

        /// <remarks />
        public const uint ProductionStartedEventType_GoodPartCount = 40;

        /// <remarks />
        public const uint ProductionStartedEventType_BadPartCount = 41;

        /// <remarks />
        public const uint ProductionStoppedEventType_JobId = 43;

        /// <remarks />
        public const uint ProductionStoppedEventType_GoodPartCount = 44;

        /// <remarks />
        public const uint ProductionStoppedEventType_BadPartCount = 45;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Machine_DeleteJob = new ExpandedNodeId(Quickstarts.FakraOpc.Methods.Machine_DeleteJob, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId Machine_GenerateReport = new ExpandedNodeId(Quickstarts.FakraOpc.Methods.Machine_GenerateReport, Quickstarts.FakraOpc.Namespaces.FakraOpc);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Machine = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.Machine, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId SystemCycleStatusEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.SystemCycleStatusEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId WireFinishedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.WireFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId BatchFinishedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.BatchFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId JobFinishedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.JobFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId JobStoppedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.JobStoppedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId ProductionStartedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.ProductionStartedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId ProductionStoppedEventType = new ExpandedNodeId(Quickstarts.FakraOpc.ObjectTypes.ProductionStoppedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Machine_AddJob_InputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_AddJob_InputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId Machine_AddJob_OutputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_AddJob_OutputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId Machine_DeleteJob_InputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_DeleteJob_InputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId Machine_GenerateReport_InputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_GenerateReport_InputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId Machine_GenerateReport_OutputArguments = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.Machine_GenerateReport_OutputArguments, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId SystemCycleStatusEventType_CycleId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.SystemCycleStatusEventType_CycleId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId WireFinishedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId WireFinishedEventType_BatchSequenceNumber = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_BatchSequenceNumber, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId WireFinishedEventType_WireSequenceNumber = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_WireSequenceNumber, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId WireFinishedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId WireFinishedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.WireFinishedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId BatchFinishedEventType_BatchSequenceNumber = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.BatchFinishedEventType_BatchSequenceNumber, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId BatchFinishedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.BatchFinishedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId BatchFinishedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.BatchFinishedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId BatchFinishedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.BatchFinishedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId JobFinishedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobFinishedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId JobFinishedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobFinishedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId JobFinishedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobFinishedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId JobStoppedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobStoppedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId JobStoppedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobStoppedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId JobStoppedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.JobStoppedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId ProductionStartedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStartedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId ProductionStartedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStartedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId ProductionStartedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStartedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId ProductionStoppedEventType_JobId = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStoppedEventType_JobId, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId ProductionStoppedEventType_GoodPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStoppedEventType_GoodPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);

        /// <remarks />
        public static readonly ExpandedNodeId ProductionStoppedEventType_BadPartCount = new ExpandedNodeId(Quickstarts.FakraOpc.Variables.ProductionStoppedEventType_BadPartCount, Quickstarts.FakraOpc.Namespaces.FakraOpc);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
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
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
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