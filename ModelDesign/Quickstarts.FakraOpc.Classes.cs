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
using System.Xml;
using System.Linq;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Quickstarts.FakraOpc
{
    #region GenerateValuesMethodState Class
    #if (!OPCUA_EXCLUDE_GenerateValuesMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenerateValuesMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public GenerateValuesMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new GenerateValuesMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////yRhggoEAAAAAQAYAAAAR2Vu" +
           "ZXJhdGVWYWx1ZXNNZXRob2RUeXBlAQGZJAMAAAAADgAAAEFkZCBhIG5ldyBqb2IuAC8BAZkkmSQAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGaJAAuAESaJAAAlgEAAAABACoBAR0A" +
           "AAAOAAAAam9iRGVzY3JpcHRpb24ADP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZskAC4ARJskAACWAQAAAAEAKgEBFAAAAAUAAABqb2JJ" +
           "ZAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public GenerateValuesMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string jobDescription = (string)_inputArguments[0];

            string jobId = (string)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    jobDescription,
                    ref jobId);
            }

            _outputArguments[0] = jobId;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult GenerateValuesMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string jobDescription,
        ref string jobId);
    #endif
    #endregion

    #region AddJobMethodState Class
    #if (!OPCUA_EXCLUDE_AddJobMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AddJobMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public AddJobMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new AddJobMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////yRhggoEAAAAAQAQAAAAQWRk" +
           "Sm9iTWV0aG9kVHlwZQEBDgADAAAAAA4AAABBZGQgYSBuZXcgam9iLgAvAQEOAA4AAAABAf////8CAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBDwAALgBEDwAAAJYEAAAAAQAqAQEWAAAABwAAAEpv" +
           "Yk5hbWUADP////8AAAAAAAEAKgEBGgAAAAsAAABKb2JRdWFudGl0eQAH/////wAAAAAAAQAqAQEcAAAA" +
           "DQAAAEJhdGNoUXVhbnRpdHkAB/////8AAAAAAAEAKgEBGAAAAAkAAABBcnRpY2xlSWQAB/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARAA" +
           "AC4ARBAAAACWAQAAAAEAKgEBFAAAAAUAAABKb2JJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public AddJobMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string jobName = (string)_inputArguments[0];
            uint jobQuantity = (uint)_inputArguments[1];
            uint batchQuantity = (uint)_inputArguments[2];
            uint articleId = (uint)_inputArguments[3];

            uint jobId = (uint)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    jobName,
                    jobQuantity,
                    batchQuantity,
                    articleId,
                    ref jobId);
            }

            _outputArguments[0] = jobId;

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult AddJobMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string jobName,
        uint jobQuantity,
        uint batchQuantity,
        uint articleId,
        ref uint jobId);
    #endif
    #endregion

    #region DeleteJobMethodState Class
    #if (!OPCUA_EXCLUDE_DeleteJobMethodState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DeleteJobMethodState : MethodState
    {
        #region Constructors
        /// <remarks />
        public DeleteJobMethodState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        public new static NodeState Construct(NodeState parent)
        {
            return new DeleteJobMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRhggoEAAAAAQATAAAARGVs" +
           "ZXRlSm9iTWV0aG9kVHlwZQEBEQAALwEBEQARAAAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBARIAAC4ARBIAAACWAQAAAAEAKgEBFAAAAAUAAABKb2JJZAAH/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <remarks />
        public DeleteJobMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <remarks />
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            uint jobId = (uint)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    jobId);
            }

            return _result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <remarks />
    /// <exclude />
    public delegate ServiceResult DeleteJobMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint jobId);
    #endif
    #endregion

    #region MachineState Class
    #if (!OPCUA_EXCLUDE_MachineState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public MachineState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.Machine, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAABAAAAAQAPAAAATWFj" +
           "aGluZUluc3RhbmNlAwEABwAAAE1hY2hpbmUDAQAHAAAATWFjaGluZf////8DAAAAJGGCCAQAAAABAAYA" +
           "AABBZGRKb2IDAQAGAAAAQWRkSm9iAwAAAAAOAAAAQWRkIGEgbmV3IGpvYi4ALwEBAAABAf////8CAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBBgAALgBEBgAAAJYEAAAAAQAqAQEWAAAABwAAAEpv" +
           "Yk5hbWUADP////8AAAAAAAEAKgEBGgAAAAsAAABKb2JRdWFudGl0eQAH/////wAAAAAAAQAqAQEcAAAA" +
           "DQAAAEJhdGNoUXVhbnRpdHkAB/////8AAAAAAAEAKgEBGAAAAAkAAABBcnRpY2xlSWQAB/////8AAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQcA" +
           "AC4ARAcAAACWAQAAAAEAKgEBFAAAAAUAAABKb2JJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAEYYIKBAAAAAEACQAAAERlbGV0ZUpvYgEBAgAALwEBAgACAAAAAQH/////AQAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQMAAC4ARAMAAACWAQAAAAEAKgEBFAAAAAUAAABKb2JJZAAH" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAkYYIKBAAAAAEADgAAAEdlbmVyYXRlUmVw" +
           "b3J0AQEJAAMAAAAADgAAAEFkZCBhIG5ldyBqb2IuAC8BAQkACQAAAAEB/////wIAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQEKAAAuAEQKAAAAlgEAAAABACoBAR0AAAAOAAAAam9iRGVzY3JpcHRp" +
           "b24ADP////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAQsAAC4ARAsAAACWAQAAAAEAKgEBFAAAAAUAAABqb2JJZAAM/////wAAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AddJobMethodState AddJob
        {
            get
            {
                return m_addJobMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_addJobMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_addJobMethod = value;
            }
        }

        /// <remarks />
        public DeleteJobMethodState DeleteJob
        {
            get
            {
                return m_deleteJobMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deleteJobMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deleteJobMethod = value;
            }
        }

        /// <remarks />
        public GenerateValuesMethodState GenerateReport
        {
            get
            {
                return m_generateReportMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_generateReportMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_generateReportMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_addJobMethod != null)
            {
                children.Add(m_addJobMethod);
            }

            if (m_deleteJobMethod != null)
            {
                children.Add(m_deleteJobMethod);
            }

            if (m_generateReportMethod != null)
            {
                children.Add(m_generateReportMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.FakraOpc.BrowseNames.AddJob:
                {
                    if (createOrReplace)
                    {
                        if (AddJob == null)
                        {
                            if (replacement == null)
                            {
                                AddJob = new AddJobMethodState(this);
                            }
                            else
                            {
                                AddJob = (AddJobMethodState)replacement;
                            }
                        }
                    }

                    instance = AddJob;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.DeleteJob:
                {
                    if (createOrReplace)
                    {
                        if (DeleteJob == null)
                        {
                            if (replacement == null)
                            {
                                DeleteJob = new DeleteJobMethodState(this);
                            }
                            else
                            {
                                DeleteJob = (DeleteJobMethodState)replacement;
                            }
                        }
                    }

                    instance = DeleteJob;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.GenerateReport:
                {
                    if (createOrReplace)
                    {
                        if (GenerateReport == null)
                        {
                            if (replacement == null)
                            {
                                GenerateReport = new GenerateValuesMethodState(this);
                            }
                            else
                            {
                                GenerateReport = (GenerateValuesMethodState)replacement;
                            }
                        }
                    }

                    instance = GenerateReport;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AddJobMethodState m_addJobMethod;
        private DeleteJobMethodState m_deleteJobMethod;
        private GenerateValuesMethodState m_generateReportMethod;
        #endregion
    }
    #endif
    #endregion

    #region SystemCycleStatusEventState Class
    #if (!OPCUA_EXCLUDE_SystemCycleStatusEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SystemCycleStatusEventState : SystemEventState
    {
        #region Constructors
        /// <remarks />
        public SystemCycleStatusEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.SystemCycleStatusEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQAiAAAAU3lz" +
           "dGVtQ3ljbGVTdGF0dXNFdmVudFR5cGVJbnN0YW5jZQEBDAABAQwADAAAAP////8JAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAgEAQUIPAAAuAERBQg8AAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAgEAQkIPAAAuAERCQg8AABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQIBAENCDwAALgBEQ0IPAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUCAQBE" +
           "Qg8AAC4ARERCDwAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAgEARUIPAAAuAERFQg8A" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQIBAEZCDwAALgBERkIPAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQIBAEhCDwAALgBESEIPAAAV/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5AgEASUIPAAAuAERJQg8AAAX/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAHAAAAQ3ljbGVJZAEBDQAALgBEDQAAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> CycleId
        {
            get
            {
                return m_cycleId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cycleId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cycleId = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_cycleId != null)
            {
                children.Add(m_cycleId);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.FakraOpc.BrowseNames.CycleId:
                {
                    if (createOrReplace)
                    {
                        if (CycleId == null)
                        {
                            if (replacement == null)
                            {
                                CycleId = new PropertyState<string>(this);
                            }
                            else
                            {
                                CycleId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = CycleId;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_cycleId;
        #endregion
    }
    #endif
    #endregion

    #region WireFinishedEventState Class
    #if (!OPCUA_EXCLUDE_WireFinishedEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WireFinishedEventState : SystemEventState
    {
        #region Constructors
        /// <remarks />
        public WireFinishedEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.WireFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQAdAAAAV2ly" +
           "ZUZpbmlzaGVkRXZlbnRUeXBlSW5zdGFuY2UBARMAAQETABMAAAD/////DQAAABVgiQoCAAAAAAAHAAAA" +
           "RXZlbnRJZAIBAEpCDwAALgBESkIPAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQIBAEtCDwAALgBES0IPAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUCAQBM" +
           "Qg8AAC4ARExCDwAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAgEATUIPAAAu" +
           "AERNQg8AAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQIBAE5CDwAALgBETkIPAAEAJgH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUCAQBPQg8AAC4ARE9CDwABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UCAQBRQg8AAC4ARFFCDwAAFf////8BAf////8A" +
           "AAAAFWCJCgIAAAAAAAgAAABTZXZlcml0eQIBAFJCDwAALgBEUkIPAAAF/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEABQAAAEpvYklkAQEUAAAuAEQUAAAAAAf/////AQH/////AAAAABVgiQoCAAAAAQATAAAAQmF0" +
           "Y2hTZXF1ZW5jZU51bWJlcgEBFQAALgBEFQAAAAAH/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAFdp" +
           "cmVTZXF1ZW5jZU51bWJlcgEBFgAALgBEFgAAAAAH/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAEdv" +
           "b2RQYXJ0Q291bnQBARcAAC4ARBcAAAAAB/////8BAf////8AAAAAFWCJCgIAAAABAAwAAABCYWRQYXJ0" +
           "Q291bnQBARgAAC4ARBgAAAAAB/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> JobId
        {
            get
            {
                return m_jobId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> BatchSequenceNumber
        {
            get
            {
                return m_batchSequenceNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_batchSequenceNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_batchSequenceNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> WireSequenceNumber
        {
            get
            {
                return m_wireSequenceNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wireSequenceNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wireSequenceNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> GoodPartCount
        {
            get
            {
                return m_goodPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> BadPartCount
        {
            get
            {
                return m_badPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_badPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_badPartCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_jobId != null)
            {
                children.Add(m_jobId);
            }

            if (m_batchSequenceNumber != null)
            {
                children.Add(m_batchSequenceNumber);
            }

            if (m_wireSequenceNumber != null)
            {
                children.Add(m_wireSequenceNumber);
            }

            if (m_goodPartCount != null)
            {
                children.Add(m_goodPartCount);
            }

            if (m_badPartCount != null)
            {
                children.Add(m_badPartCount);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.FakraOpc.BrowseNames.JobId:
                {
                    if (createOrReplace)
                    {
                        if (JobId == null)
                        {
                            if (replacement == null)
                            {
                                JobId = new PropertyState<uint>(this);
                            }
                            else
                            {
                                JobId = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = JobId;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.BatchSequenceNumber:
                {
                    if (createOrReplace)
                    {
                        if (BatchSequenceNumber == null)
                        {
                            if (replacement == null)
                            {
                                BatchSequenceNumber = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BatchSequenceNumber = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BatchSequenceNumber;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.WireSequenceNumber:
                {
                    if (createOrReplace)
                    {
                        if (WireSequenceNumber == null)
                        {
                            if (replacement == null)
                            {
                                WireSequenceNumber = new PropertyState<uint>(this);
                            }
                            else
                            {
                                WireSequenceNumber = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = WireSequenceNumber;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.GoodPartCount:
                {
                    if (createOrReplace)
                    {
                        if (GoodPartCount == null)
                        {
                            if (replacement == null)
                            {
                                GoodPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                GoodPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = GoodPartCount;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.BadPartCount:
                {
                    if (createOrReplace)
                    {
                        if (BadPartCount == null)
                        {
                            if (replacement == null)
                            {
                                BadPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BadPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BadPartCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<uint> m_jobId;
        private PropertyState<uint> m_batchSequenceNumber;
        private PropertyState<uint> m_wireSequenceNumber;
        private PropertyState<uint> m_goodPartCount;
        private PropertyState<uint> m_badPartCount;
        #endregion
    }
    #endif
    #endregion

    #region BatchFinishedEventState Class
    #if (!OPCUA_EXCLUDE_BatchFinishedEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BatchFinishedEventState : SystemEventState
    {
        #region Constructors
        /// <remarks />
        public BatchFinishedEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.BatchFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQAeAAAAQmF0" +
           "Y2hGaW5pc2hlZEV2ZW50VHlwZUluc3RhbmNlAQHoCwEB6AvoCwAA/////wwAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQCAQBTQg8AAC4ARFNCDwAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5" +
           "cGUCAQBUQg8AAC4ARFRCDwAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAgEA" +
           "VUIPAAAuAERVQg8AABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQIBAFZCDwAA" +
           "LgBEVkIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUCAQBXQg8AAC4ARFdCDwABACYB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAgEAWEIPAAAuAERYQg8AAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAgEAWkIPAAAuAERaQg8AABX/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkCAQBbQg8AAC4ARFtCDwAABf////8BAf////8AAAAAFWCJ" +
           "CgIAAAABABMAAABCYXRjaFNlcXVlbmNlTnVtYmVyAQEEAAAuAEQEAAAAAAf/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAFAAAASm9iSWQBAQUAAC4ARAUAAAAAB/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABH" +
           "b29kUGFydENvdW50AQEZAAAuAEQZAAAAAAf/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAQmFkUGFy" +
           "dENvdW50AQEaAAAuAEQaAAAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> BatchSequenceNumber
        {
            get
            {
                return m_batchSequenceNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_batchSequenceNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_batchSequenceNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> JobId
        {
            get
            {
                return m_jobId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> GoodPartCount
        {
            get
            {
                return m_goodPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> BadPartCount
        {
            get
            {
                return m_badPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_badPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_badPartCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_batchSequenceNumber != null)
            {
                children.Add(m_batchSequenceNumber);
            }

            if (m_jobId != null)
            {
                children.Add(m_jobId);
            }

            if (m_goodPartCount != null)
            {
                children.Add(m_goodPartCount);
            }

            if (m_badPartCount != null)
            {
                children.Add(m_badPartCount);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.FakraOpc.BrowseNames.BatchSequenceNumber:
                {
                    if (createOrReplace)
                    {
                        if (BatchSequenceNumber == null)
                        {
                            if (replacement == null)
                            {
                                BatchSequenceNumber = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BatchSequenceNumber = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BatchSequenceNumber;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.JobId:
                {
                    if (createOrReplace)
                    {
                        if (JobId == null)
                        {
                            if (replacement == null)
                            {
                                JobId = new PropertyState<uint>(this);
                            }
                            else
                            {
                                JobId = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = JobId;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.GoodPartCount:
                {
                    if (createOrReplace)
                    {
                        if (GoodPartCount == null)
                        {
                            if (replacement == null)
                            {
                                GoodPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                GoodPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = GoodPartCount;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.BadPartCount:
                {
                    if (createOrReplace)
                    {
                        if (BadPartCount == null)
                        {
                            if (replacement == null)
                            {
                                BadPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BadPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BadPartCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<uint> m_batchSequenceNumber;
        private PropertyState<uint> m_jobId;
        private PropertyState<uint> m_goodPartCount;
        private PropertyState<uint> m_badPartCount;
        #endregion
    }
    #endif
    #endregion

    #region JobFinishedEventState Class
    #if (!OPCUA_EXCLUDE_JobFinishedEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class JobFinishedEventState : SystemEventState
    {
        #region Constructors
        /// <remarks />
        public JobFinishedEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.JobFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQAcAAAASm9i" +
           "RmluaXNoZWRFdmVudFR5cGVJbnN0YW5jZQEBHgABAR4AHgAAAP////8LAAAAFWCJCgIAAAAAAAcAAABF" +
           "dmVudElkAgEAXEIPAAAuAERcQg8AAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBl" +
           "AgEAXUIPAAAuAERdQg8AABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQIBAF5C" +
           "DwAALgBEXkIPAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUCAQBfQg8AAC4A" +
           "RF9CDwAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAgEAYEIPAAAuAERgQg8AAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQIBAGFCDwAALgBEYUIPAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQIBAGNCDwAALgBEY0IPAAAV/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACAAAAFNldmVyaXR5AgEAZEIPAAAuAERkQg8AAAX/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAFAAAASm9iSWQBAR8AAC4ARB8AAAAAB/////8BAf////8AAAAAFWCJCgIAAAABAA0AAABHb29k" +
           "UGFydENvdW50AQEgAAAuAEQgAAAAAAf/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAQmFkUGFydENv" +
           "dW50AQEhAAAuAEQhAAAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> JobId
        {
            get
            {
                return m_jobId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> GoodPartCount
        {
            get
            {
                return m_goodPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> BadPartCount
        {
            get
            {
                return m_badPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_badPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_badPartCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_jobId != null)
            {
                children.Add(m_jobId);
            }

            if (m_goodPartCount != null)
            {
                children.Add(m_goodPartCount);
            }

            if (m_badPartCount != null)
            {
                children.Add(m_badPartCount);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.FakraOpc.BrowseNames.JobId:
                {
                    if (createOrReplace)
                    {
                        if (JobId == null)
                        {
                            if (replacement == null)
                            {
                                JobId = new PropertyState<uint>(this);
                            }
                            else
                            {
                                JobId = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = JobId;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.GoodPartCount:
                {
                    if (createOrReplace)
                    {
                        if (GoodPartCount == null)
                        {
                            if (replacement == null)
                            {
                                GoodPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                GoodPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = GoodPartCount;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.BadPartCount:
                {
                    if (createOrReplace)
                    {
                        if (BadPartCount == null)
                        {
                            if (replacement == null)
                            {
                                BadPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BadPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BadPartCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<uint> m_jobId;
        private PropertyState<uint> m_goodPartCount;
        private PropertyState<uint> m_badPartCount;
        #endregion
    }
    #endif
    #endregion

    #region JobStoppedEventState Class
    #if (!OPCUA_EXCLUDE_JobStoppedEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class JobStoppedEventState : SystemEventState
    {
        #region Constructors
        /// <remarks />
        public JobStoppedEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.JobStoppedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQAbAAAASm9i" +
           "U3RvcHBlZEV2ZW50VHlwZUluc3RhbmNlAQEiAAEBIgAiAAAA/////wsAAAAVYIkKAgAAAAAABwAAAEV2" +
           "ZW50SWQCAQBlQg8AAC4ARGVCDwAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUC" +
           "AQBmQg8AAC4ARGZCDwAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAgEAZ0IP" +
           "AAAuAERnQg8AABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQIBAGhCDwAALgBE" +
           "aEIPAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUCAQBpQg8AAC4ARGlCDwABACYB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAgEAakIPAAAuAERqQg8AAQAmAf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAgEAbEIPAAAuAERsQg8AABX/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkCAQBtQg8AAC4ARG1CDwAABf////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAUAAABKb2JJZAEBIwAALgBEIwAAAAAH/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAEdvb2RQ" +
           "YXJ0Q291bnQBASQAAC4ARCQAAAAAB/////8BAf////8AAAAAFWCJCgIAAAABAAwAAABCYWRQYXJ0Q291" +
           "bnQBASUAAC4ARCUAAAAAB/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> JobId
        {
            get
            {
                return m_jobId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> GoodPartCount
        {
            get
            {
                return m_goodPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> BadPartCount
        {
            get
            {
                return m_badPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_badPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_badPartCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_jobId != null)
            {
                children.Add(m_jobId);
            }

            if (m_goodPartCount != null)
            {
                children.Add(m_goodPartCount);
            }

            if (m_badPartCount != null)
            {
                children.Add(m_badPartCount);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.FakraOpc.BrowseNames.JobId:
                {
                    if (createOrReplace)
                    {
                        if (JobId == null)
                        {
                            if (replacement == null)
                            {
                                JobId = new PropertyState<uint>(this);
                            }
                            else
                            {
                                JobId = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = JobId;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.GoodPartCount:
                {
                    if (createOrReplace)
                    {
                        if (GoodPartCount == null)
                        {
                            if (replacement == null)
                            {
                                GoodPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                GoodPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = GoodPartCount;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.BadPartCount:
                {
                    if (createOrReplace)
                    {
                        if (BadPartCount == null)
                        {
                            if (replacement == null)
                            {
                                BadPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BadPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BadPartCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<uint> m_jobId;
        private PropertyState<uint> m_goodPartCount;
        private PropertyState<uint> m_badPartCount;
        #endregion
    }
    #endif
    #endregion

    #region ProductionStartedEventState Class
    #if (!OPCUA_EXCLUDE_ProductionStartedEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProductionStartedEventState : SystemEventState
    {
        #region Constructors
        /// <remarks />
        public ProductionStartedEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.ProductionStartedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQAiAAAAUHJv" +
           "ZHVjdGlvblN0YXJ0ZWRFdmVudFR5cGVJbnN0YW5jZQEBJgABASYAJgAAAP////8LAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAgEAbkIPAAAuAERuQg8AAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAgEAb0IPAAAuAERvQg8AABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQIBAHBCDwAALgBEcEIPAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUCAQBx" +
           "Qg8AAC4ARHFCDwAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAgEAckIPAAAuAERyQg8A" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQIBAHNCDwAALgBEc0IPAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQIBAHVCDwAALgBEdUIPAAAV/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5AgEAdkIPAAAuAER2Qg8AAAX/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAFAAAASm9iSWQBAScAAC4ARCcAAAAAB/////8BAf////8AAAAAFWCJCgIAAAABAA0A" +
           "AABHb29kUGFydENvdW50AQEoAAAuAEQoAAAAAAf/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAQmFk" +
           "UGFydENvdW50AQEpAAAuAEQpAAAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> JobId
        {
            get
            {
                return m_jobId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> GoodPartCount
        {
            get
            {
                return m_goodPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> BadPartCount
        {
            get
            {
                return m_badPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_badPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_badPartCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_jobId != null)
            {
                children.Add(m_jobId);
            }

            if (m_goodPartCount != null)
            {
                children.Add(m_goodPartCount);
            }

            if (m_badPartCount != null)
            {
                children.Add(m_badPartCount);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.FakraOpc.BrowseNames.JobId:
                {
                    if (createOrReplace)
                    {
                        if (JobId == null)
                        {
                            if (replacement == null)
                            {
                                JobId = new PropertyState<uint>(this);
                            }
                            else
                            {
                                JobId = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = JobId;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.GoodPartCount:
                {
                    if (createOrReplace)
                    {
                        if (GoodPartCount == null)
                        {
                            if (replacement == null)
                            {
                                GoodPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                GoodPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = GoodPartCount;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.BadPartCount:
                {
                    if (createOrReplace)
                    {
                        if (BadPartCount == null)
                        {
                            if (replacement == null)
                            {
                                BadPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BadPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BadPartCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<uint> m_jobId;
        private PropertyState<uint> m_goodPartCount;
        private PropertyState<uint> m_badPartCount;
        #endregion
    }
    #endif
    #endregion

    #region ProductionStoppedEventState Class
    #if (!OPCUA_EXCLUDE_ProductionStoppedEventState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProductionStoppedEventState : SystemEventState
    {
        #region Constructors
        /// <remarks />
        public ProductionStoppedEventState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.ProductionStoppedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQAiAAAAUHJv" +
           "ZHVjdGlvblN0b3BwZWRFdmVudFR5cGVJbnN0YW5jZQEBKgABASoAKgAAAP////8LAAAAFWCJCgIAAAAA" +
           "AAcAAABFdmVudElkAgEAd0IPAAAuAER3Qg8AAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZl" +
           "bnRUeXBlAgEAeEIPAAAuAER4Qg8AABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9k" +
           "ZQIBAHlCDwAALgBEeUIPAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUCAQB6" +
           "Qg8AAC4ARHpCDwAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAgEAe0IPAAAuAER7Qg8A" +
           "AQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQIBAHxCDwAALgBEfEIPAAEA" +
           "JgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQIBAH5CDwAALgBEfkIPAAAV/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5AgEAf0IPAAAuAER/Qg8AAAX/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAFAAAASm9iSWQBASsAAC4ARCsAAAAAB/////8BAf////8AAAAAFWCJCgIAAAABAA0A" +
           "AABHb29kUGFydENvdW50AQEsAAAuAEQsAAAAAAf/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAQmFk" +
           "UGFydENvdW50AQEtAAAuAEQtAAAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> JobId
        {
            get
            {
                return m_jobId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> GoodPartCount
        {
            get
            {
                return m_goodPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> BadPartCount
        {
            get
            {
                return m_badPartCount;
            }

            set
            {
                if (!Object.ReferenceEquals(m_badPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_badPartCount = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_jobId != null)
            {
                children.Add(m_jobId);
            }

            if (m_goodPartCount != null)
            {
                children.Add(m_goodPartCount);
            }

            if (m_badPartCount != null)
            {
                children.Add(m_badPartCount);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Quickstarts.FakraOpc.BrowseNames.JobId:
                {
                    if (createOrReplace)
                    {
                        if (JobId == null)
                        {
                            if (replacement == null)
                            {
                                JobId = new PropertyState<uint>(this);
                            }
                            else
                            {
                                JobId = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = JobId;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.GoodPartCount:
                {
                    if (createOrReplace)
                    {
                        if (GoodPartCount == null)
                        {
                            if (replacement == null)
                            {
                                GoodPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                GoodPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = GoodPartCount;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.BadPartCount:
                {
                    if (createOrReplace)
                    {
                        if (BadPartCount == null)
                        {
                            if (replacement == null)
                            {
                                BadPartCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BadPartCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BadPartCount;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<uint> m_jobId;
        private PropertyState<uint> m_goodPartCount;
        private PropertyState<uint> m_badPartCount;
        #endregion
    }
    #endif
    #endregion
}