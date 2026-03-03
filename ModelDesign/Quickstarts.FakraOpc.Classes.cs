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
using System.Threading.Tasks;
using System.Threading;
using Opc.Ua;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1515 // Consider making public types internal
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1028 // Enum Storage should be Int32

namespace Quickstarts.FakraOpc
{
    #region AddJobMethodState Class
    #if (!OPCUA_EXCLUDE_AddJobMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class AddJobMethodState : MethodState
    {
        #region Constructors
        public AddJobMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new AddJobMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

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
        public AddJobMethodStateMethodCallHandler OnCall;

        public AddJobMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
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

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            AddJobMethodStateResult _result = null;

            string jobName = (string)_inputArguments[0];
            uint jobQuantity = (uint)_inputArguments[1];
            uint batchQuantity = (uint)_inputArguments[2];
            uint articleId = (uint)_inputArguments[3];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    jobName,
                    jobQuantity,
                    batchQuantity,
                    articleId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.JobId;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

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

    /// <exclude />
    public partial class AddJobMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public uint JobId { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<AddJobMethodStateResult> AddJobMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string jobName,
        uint jobQuantity,
        uint batchQuantity,
        uint articleId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region ActivateJobMethodState Class
    #if (!OPCUA_EXCLUDE_ActivateJobMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ActivateJobMethodState : MethodState
    {
        #region Constructors
        public ActivateJobMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new ActivateJobMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////yRhggoEAAAAAQAVAAAAQWN0" +
           "aXZhdGVKb2JNZXRob2RUeXBlAQEbAAMAAAAAHgAAAEFjdGl2YXRlIGEgam9iIGZvciBwcm9kdWN0aW9u" +
           "LgAvAQEbABsAAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBHAAALgBEHAAA" +
           "AJYBAAAAAQAqAQEUAAAABQAAAEpvYklkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public ActivateJobMethodStateMethodCallHandler OnCall;

        public ActivateJobMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
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

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            ActivateJobMethodStateResult _result = null;

            uint jobId = (uint)_inputArguments[0];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    jobId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult ActivateJobMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint jobId);

    /// <exclude />
    public partial class ActivateJobMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<ActivateJobMethodStateResult> ActivateJobMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint jobId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region DeleteJobMethodState Class
    #if (!OPCUA_EXCLUDE_DeleteJobMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class DeleteJobMethodState : MethodState
    {
        #region Constructors
        public DeleteJobMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new DeleteJobMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////yRhggoEAAAAAQATAAAARGVs" +
           "ZXRlSm9iTWV0aG9kVHlwZQEBEQADAAAAAB4AAABEZWxldGUgYSBqb2IgZnJvbSB0aGUgbWFjaGluZS4A" +
           "LwEBEQARAAAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBARIAAC4ARBIAAACW" +
           "AQAAAAEAKgEBFAAAAAUAAABKb2JJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public DeleteJobMethodStateMethodCallHandler OnCall;

        public DeleteJobMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
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

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            DeleteJobMethodStateResult _result = null;

            uint jobId = (uint)_inputArguments[0];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    jobId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult DeleteJobMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint jobId);

    /// <exclude />
    public partial class DeleteJobMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<DeleteJobMethodStateResult> DeleteJobMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint jobId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region GenerateReportMethodState Class
    #if (!OPCUA_EXCLUDE_GenerateReportMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class GenerateReportMethodState : MethodState
    {
        #region Constructors
        public GenerateReportMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new GenerateReportMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////yRhggoEAAAAAQAYAAAAR2Vu" +
           "ZXJhdGVSZXBvcnRNZXRob2RUeXBlAQEdAAMAAAAAFwAAAEdlbmVyYXRlIGEgcmVwb3J0IGZpbGUuAC8B" +
           "AR0AHQAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEuAAAuAEQuAAAAlgMA" +
           "AAABACoBARQAAAAFAAAASm9iSWQAB/////8AAAAAAAEAKgEBFAAAAAUAAABTY29wZQAG/////wAAAAAA" +
           "AQAqAQEWAAAABwAAAFNjb3BlSWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAS8AAC4ARC8AAACWAQAAAAEAKgEBHQAAAA4AAABSZXBv" +
           "cnRGaWxlTm9kZQAR/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public GenerateReportMethodStateMethodCallHandler OnCall;

        public GenerateReportMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
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
            int scope = (int)_inputArguments[1];
            uint scopeId = (uint)_inputArguments[2];

            NodeId reportFileNode = (NodeId)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    jobId,
                    scope,
                    scopeId,
                    ref reportFileNode);
            }

            _outputArguments[0] = reportFileNode;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            GenerateReportMethodStateResult _result = null;

            uint jobId = (uint)_inputArguments[0];
            int scope = (int)_inputArguments[1];
            uint scopeId = (uint)_inputArguments[2];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    jobId,
                    scope,
                    scopeId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.ReportFileNode;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult GenerateReportMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint jobId,
        int scope,
        uint scopeId,
        ref NodeId reportFileNode);

    /// <exclude />
    public partial class GenerateReportMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public NodeId ReportFileNode { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<GenerateReportMethodStateResult> GenerateReportMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        uint jobId,
        int scope,
        uint scopeId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region ArticleState Class
    #if (!OPCUA_EXCLUDE_ArticleState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ArticleState : BaseObjectState
    {
        #region Constructors
        public ArticleState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.ArticleType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQATAAAAQXJ0" +
           "aWNsZVR5cGVJbnN0YW5jZQEBMAABATAAMAAAAP////8EAAAAFWCJCgIAAAABAAkAAABBcnRpY2xlSWQB" +
           "ATEAAC4ARDEAAAAAB/////8BAf////8AAAAAFWCJCgIAAAABAAsAAABBcnRpY2xlTmFtZQEBMgAALgBE" +
           "MgAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAEFydGljbGVOdW1iZXIBATMAAC4ARDMAAAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAA0AAABDYW5CZVByb2R1Y2VkAQE0AAAuAEQ0AAAAAAH/////" +
           "AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<uint> ArticleId
        {
            get => m_articleId;

            set
            {
                if (!Object.ReferenceEquals(m_articleId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_articleId = value;
            }
        }

        public PropertyState<string> ArticleName
        {
            get => m_articleName;

            set
            {
                if (!Object.ReferenceEquals(m_articleName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_articleName = value;
            }
        }

        public PropertyState<string> ArticleNumber
        {
            get => m_articleNumber;

            set
            {
                if (!Object.ReferenceEquals(m_articleNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_articleNumber = value;
            }
        }

        public PropertyState<bool> CanBeProduced
        {
            get => m_canBeProduced;

            set
            {
                if (!Object.ReferenceEquals(m_canBeProduced, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_canBeProduced = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_articleId != null)
            {
                children.Add(m_articleId);
            }

            if (m_articleName != null)
            {
                children.Add(m_articleName);
            }

            if (m_articleNumber != null)
            {
                children.Add(m_articleNumber);
            }

            if (m_canBeProduced != null)
            {
                children.Add(m_canBeProduced);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_articleId, child))
            {
                m_articleId = null;
                return;
            }

            if (Object.ReferenceEquals(m_articleName, child))
            {
                m_articleName = null;
                return;
            }

            if (Object.ReferenceEquals(m_articleNumber, child))
            {
                m_articleNumber = null;
                return;
            }

            if (Object.ReferenceEquals(m_canBeProduced, child))
            {
                m_canBeProduced = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
                case Quickstarts.FakraOpc.BrowseNames.ArticleId:
                {
                    if (createOrReplace)
                    {
                        if (ArticleId == null)
                        {
                            if (replacement == null)
                            {
                                ArticleId = new PropertyState<uint>(this);
                            }
                            else
                            {
                                ArticleId = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = ArticleId;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.ArticleName:
                {
                    if (createOrReplace)
                    {
                        if (ArticleName == null)
                        {
                            if (replacement == null)
                            {
                                ArticleName = new PropertyState<string>(this);
                            }
                            else
                            {
                                ArticleName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ArticleName;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.ArticleNumber:
                {
                    if (createOrReplace)
                    {
                        if (ArticleNumber == null)
                        {
                            if (replacement == null)
                            {
                                ArticleNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                ArticleNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ArticleNumber;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.CanBeProduced:
                {
                    if (createOrReplace)
                    {
                        if (CanBeProduced == null)
                        {
                            if (replacement == null)
                            {
                                CanBeProduced = new PropertyState<bool>(this);
                            }
                            else
                            {
                                CanBeProduced = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = CanBeProduced;
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
        private PropertyState<uint> m_articleId;
        private PropertyState<string> m_articleName;
        private PropertyState<string> m_articleNumber;
        private PropertyState<bool> m_canBeProduced;
        #endregion
    }
    #endif
    #endregion

    #region JobInfoState Class
    #if (!OPCUA_EXCLUDE_JobInfoState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class JobInfoState : BaseObjectState
    {
        #region Constructors
        public JobInfoState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.JobInfoType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ActivationTime != null)
            {
                ActivationTime.Initialize(context, ActivationTime_InitializationString);
            }
        }

        #region Initialization String
        private const string ActivationTime_InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////xVgiQoCAAAAAQAOAAAAQWN0" +
           "aXZhdGlvblRpbWUBAVIAAC4ARFIAAAAADf////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQATAAAASm9i" +
           "SW5mb1R5cGVJbnN0YW5jZQEBSAABAUgASAAAAP////8KAAAAFWCJCgIAAAABAAUAAABKb2JJZAEBSQAA" +
           "LgBESQAAAAAH/////wEB/////wAAAAAVYIkKAgAAAAEABwAAAEpvYk5hbWUBAUoAAC4AREoAAAAADP//" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAsAAABKb2JRdWFudGl0eQEBSwAALgBESwAAAAAH/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEADQAAAEdvb2RQYXJ0Q291bnQBAUwAAC4AREwAAAAAB/////8BAf////8AAAAA" +
           "FWCJCgIAAAABAAwAAABCYWRQYXJ0Q291bnQBAU0AAC4ARE0AAAAAB/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAA0AAABCYXRjaFF1YW50aXR5AQFOAAAuAEROAAAAAAf/////AQH/////AAAAABVgiQoCAAAAAQAK" +
           "AAAAQmF0Y2hDb3VudAEBTwAALgBETwAAAAAH/////wEB/////wAAAAAVYIkKAgAAAAEACQAAAEFydGlj" +
           "bGVJZAEBUAAALgBEUAAAAAAH/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAEpvYlN0YXRlAQFRAAAu" +
           "AERRAAAAAAb/////AQH/////AAAAABVgiQoCAAAAAQAOAAAAQWN0aXZhdGlvblRpbWUBAVIAAC4ARFIA" +
           "AAAADf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<uint> JobId
        {
            get => m_jobId;

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        public PropertyState<string> JobName
        {
            get => m_jobName;

            set
            {
                if (!Object.ReferenceEquals(m_jobName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobName = value;
            }
        }

        public PropertyState<uint> JobQuantity
        {
            get => m_jobQuantity;

            set
            {
                if (!Object.ReferenceEquals(m_jobQuantity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobQuantity = value;
            }
        }

        public PropertyState<uint> GoodPartCount
        {
            get => m_goodPartCount;

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        public PropertyState<uint> BadPartCount
        {
            get => m_badPartCount;

            set
            {
                if (!Object.ReferenceEquals(m_badPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_badPartCount = value;
            }
        }

        public PropertyState<uint> BatchQuantity
        {
            get => m_batchQuantity;

            set
            {
                if (!Object.ReferenceEquals(m_batchQuantity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_batchQuantity = value;
            }
        }

        public PropertyState<uint> BatchCount
        {
            get => m_batchCount;

            set
            {
                if (!Object.ReferenceEquals(m_batchCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_batchCount = value;
            }
        }

        public PropertyState<uint> ArticleId
        {
            get => m_articleId;

            set
            {
                if (!Object.ReferenceEquals(m_articleId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_articleId = value;
            }
        }

        public PropertyState<int> JobState
        {
            get => m_jobState;

            set
            {
                if (!Object.ReferenceEquals(m_jobState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobState = value;
            }
        }

        public PropertyState<DateTime> ActivationTime
        {
            get => m_activationTime;

            set
            {
                if (!Object.ReferenceEquals(m_activationTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activationTime = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_jobId != null)
            {
                children.Add(m_jobId);
            }

            if (m_jobName != null)
            {
                children.Add(m_jobName);
            }

            if (m_jobQuantity != null)
            {
                children.Add(m_jobQuantity);
            }

            if (m_goodPartCount != null)
            {
                children.Add(m_goodPartCount);
            }

            if (m_badPartCount != null)
            {
                children.Add(m_badPartCount);
            }

            if (m_batchQuantity != null)
            {
                children.Add(m_batchQuantity);
            }

            if (m_batchCount != null)
            {
                children.Add(m_batchCount);
            }

            if (m_articleId != null)
            {
                children.Add(m_articleId);
            }

            if (m_jobState != null)
            {
                children.Add(m_jobState);
            }

            if (m_activationTime != null)
            {
                children.Add(m_activationTime);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_jobId, child))
            {
                m_jobId = null;
                return;
            }

            if (Object.ReferenceEquals(m_jobName, child))
            {
                m_jobName = null;
                return;
            }

            if (Object.ReferenceEquals(m_jobQuantity, child))
            {
                m_jobQuantity = null;
                return;
            }

            if (Object.ReferenceEquals(m_goodPartCount, child))
            {
                m_goodPartCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_badPartCount, child))
            {
                m_badPartCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_batchQuantity, child))
            {
                m_batchQuantity = null;
                return;
            }

            if (Object.ReferenceEquals(m_batchCount, child))
            {
                m_batchCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_articleId, child))
            {
                m_articleId = null;
                return;
            }

            if (Object.ReferenceEquals(m_jobState, child))
            {
                m_jobState = null;
                return;
            }

            if (Object.ReferenceEquals(m_activationTime, child))
            {
                m_activationTime = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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

                case Quickstarts.FakraOpc.BrowseNames.JobName:
                {
                    if (createOrReplace)
                    {
                        if (JobName == null)
                        {
                            if (replacement == null)
                            {
                                JobName = new PropertyState<string>(this);
                            }
                            else
                            {
                                JobName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = JobName;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.JobQuantity:
                {
                    if (createOrReplace)
                    {
                        if (JobQuantity == null)
                        {
                            if (replacement == null)
                            {
                                JobQuantity = new PropertyState<uint>(this);
                            }
                            else
                            {
                                JobQuantity = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = JobQuantity;
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

                case Quickstarts.FakraOpc.BrowseNames.BatchQuantity:
                {
                    if (createOrReplace)
                    {
                        if (BatchQuantity == null)
                        {
                            if (replacement == null)
                            {
                                BatchQuantity = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BatchQuantity = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BatchQuantity;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.BatchCount:
                {
                    if (createOrReplace)
                    {
                        if (BatchCount == null)
                        {
                            if (replacement == null)
                            {
                                BatchCount = new PropertyState<uint>(this);
                            }
                            else
                            {
                                BatchCount = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = BatchCount;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.ArticleId:
                {
                    if (createOrReplace)
                    {
                        if (ArticleId == null)
                        {
                            if (replacement == null)
                            {
                                ArticleId = new PropertyState<uint>(this);
                            }
                            else
                            {
                                ArticleId = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = ArticleId;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.JobState:
                {
                    if (createOrReplace)
                    {
                        if (JobState == null)
                        {
                            if (replacement == null)
                            {
                                JobState = new PropertyState<int>(this);
                            }
                            else
                            {
                                JobState = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = JobState;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.ActivationTime:
                {
                    if (createOrReplace)
                    {
                        if (ActivationTime == null)
                        {
                            if (replacement == null)
                            {
                                ActivationTime = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                ActivationTime = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = ActivationTime;
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
        private PropertyState<string> m_jobName;
        private PropertyState<uint> m_jobQuantity;
        private PropertyState<uint> m_goodPartCount;
        private PropertyState<uint> m_badPartCount;
        private PropertyState<uint> m_batchQuantity;
        private PropertyState<uint> m_batchCount;
        private PropertyState<uint> m_articleId;
        private PropertyState<int> m_jobState;
        private PropertyState<DateTime> m_activationTime;
        #endregion
    }
    #endif
    #endregion

    #region JobListState Class
    #if (!OPCUA_EXCLUDE_JobListState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class JobListState : BaseObjectState
    {
        #region Constructors
        public JobListState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.JobListType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQATAAAASm9i" +
           "TGlzdFR5cGVJbnN0YW5jZQEBQAABAUAAQAAAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ArticleListState Class
    #if (!OPCUA_EXCLUDE_ArticleListState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ArticleListState : BaseObjectState
    {
        #region Constructors
        public ArticleListState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.ArticleListType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wRggAIBAAAAAQAXAAAAQXJ0" +
           "aWNsZUxpc3RUeXBlSW5zdGFuY2UBAUEAAQFBAEEAAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MachineState Class
    #if (!OPCUA_EXCLUDE_MachineState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class MachineState : BaseObjectState
    {
        #region Constructors
        public MachineState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.Machine, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////4RggAABAAAAAQAPAAAATWFj" +
           "aGluZUluc3RhbmNlAwEABwAAAE1hY2hpbmUDAQAHAAAATWFjaGluZQH/////CAAAABVgiQoCAAAAAQAQ" +
           "AAAAUHJvZHVjdGlvblN0YXR1cwEBQgAALgBEQgAAAAAG/////wEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AEFjdGl2ZUpvYlN0YXRlAQFDAAAuAERDAAAAAAb/////AQH/////AAAAAARggAoBAAAAAQAHAAAASm9i" +
           "TGlzdAEBRAAALwEBQABEAAAA/////wAAAAAEYIAKAQAAAAEACwAAAEFydGljbGVMaXN0AQFFAAAvAQFB" +
           "AEUAAAD/////AAAAACRhgggEAAAAAQAGAAAAQWRkSm9iAwEABgAAAEFkZEpvYgMAAAAADgAAAEFkZCBh" +
           "IG5ldyBqb2IuAC8BAQAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQYAAC4A" +
           "RAYAAACWBAAAAAEAKgEBFgAAAAcAAABKb2JOYW1lAAz/////AAAAAAABACoBARoAAAALAAAASm9iUXVh" +
           "bnRpdHkAB/////8AAAAAAAEAKgEBHAAAAA0AAABCYXRjaFF1YW50aXR5AAf/////AAAAAAABACoBARgA" +
           "AAAJAAAAQXJ0aWNsZUlkAAf/////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQEHAAAuAEQHAAAAlgEAAAABACoBARQAAAAFAAAASm9iSWQAB///" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAJGGCCgQAAAABAAsAAABBY3RpdmF0ZUpvYgEB" +
           "RgADAAAAAB4AAABBY3RpdmF0ZSBhIGpvYiBmb3IgcHJvZHVjdGlvbi4ALwEBRgBGAAAAAQH/////AQAA" +
           "ABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUcAAC4AREcAAACWAQAAAAEAKgEBFAAAAAUAAABK" +
           "b2JJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAkYYIKBAAAAAEACQAAAERlbGV0" +
           "ZUpvYgEBAgADAAAAAB4AAABEZWxldGUgYSBqb2IgZnJvbSB0aGUgbWFjaGluZS4ALwEBAgACAAAAAQH/" +
           "////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQMAAC4ARAMAAACWAQAAAAEAKgEBFAAA" +
           "AAUAAABKb2JJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAkYYIKBAAAAAEADgAA" +
           "AEdlbmVyYXRlUmVwb3J0AQEJAAMAAAAAFwAAAEdlbmVyYXRlIGEgcmVwb3J0IGZpbGUuAC8BAQkACQAA" +
           "AAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEKAAAuAEQKAAAAlgMAAAABACoB" +
           "ARQAAAAFAAAASm9iSWQAB/////8AAAAAAAEAKgEBFAAAAAUAAABTY29wZQAG/////wAAAAAAAQAqAQEW" +
           "AAAABwAAAFNjb3BlSWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAQsAAC4ARAsAAACWAQAAAAEAKgEBHQAAAA4AAABSZXBvcnRGaWxl" +
           "Tm9kZQAR/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<int> ProductionStatus
        {
            get => m_productionStatus;

            set
            {
                if (!Object.ReferenceEquals(m_productionStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productionStatus = value;
            }
        }

        public PropertyState<int> ActiveJobState
        {
            get => m_activeJobState;

            set
            {
                if (!Object.ReferenceEquals(m_activeJobState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activeJobState = value;
            }
        }

        public JobListState JobList
        {
            get => m_jobList;

            set
            {
                if (!Object.ReferenceEquals(m_jobList, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobList = value;
            }
        }

        public ArticleListState ArticleList
        {
            get => m_articleList;

            set
            {
                if (!Object.ReferenceEquals(m_articleList, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_articleList = value;
            }
        }

        public AddJobMethodState AddJob
        {
            get => m_addJobMethod;

            set
            {
                if (!Object.ReferenceEquals(m_addJobMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_addJobMethod = value;
            }
        }

        public ActivateJobMethodState ActivateJob
        {
            get => m_activateJobMethod;

            set
            {
                if (!Object.ReferenceEquals(m_activateJobMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activateJobMethod = value;
            }
        }

        public DeleteJobMethodState DeleteJob
        {
            get => m_deleteJobMethod;

            set
            {
                if (!Object.ReferenceEquals(m_deleteJobMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deleteJobMethod = value;
            }
        }

        public GenerateReportMethodState GenerateReport
        {
            get => m_generateReportMethod;

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
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_productionStatus != null)
            {
                children.Add(m_productionStatus);
            }

            if (m_activeJobState != null)
            {
                children.Add(m_activeJobState);
            }

            if (m_jobList != null)
            {
                children.Add(m_jobList);
            }

            if (m_articleList != null)
            {
                children.Add(m_articleList);
            }

            if (m_addJobMethod != null)
            {
                children.Add(m_addJobMethod);
            }

            if (m_activateJobMethod != null)
            {
                children.Add(m_activateJobMethod);
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
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_productionStatus, child))
            {
                m_productionStatus = null;
                return;
            }

            if (Object.ReferenceEquals(m_activeJobState, child))
            {
                m_activeJobState = null;
                return;
            }

            if (Object.ReferenceEquals(m_jobList, child))
            {
                m_jobList = null;
                return;
            }

            if (Object.ReferenceEquals(m_articleList, child))
            {
                m_articleList = null;
                return;
            }

            if (Object.ReferenceEquals(m_addJobMethod, child))
            {
                m_addJobMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_activateJobMethod, child))
            {
                m_activateJobMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_deleteJobMethod, child))
            {
                m_deleteJobMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_generateReportMethod, child))
            {
                m_generateReportMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
                case Quickstarts.FakraOpc.BrowseNames.ProductionStatus:
                {
                    if (createOrReplace)
                    {
                        if (ProductionStatus == null)
                        {
                            if (replacement == null)
                            {
                                ProductionStatus = new PropertyState<int>(this);
                            }
                            else
                            {
                                ProductionStatus = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = ProductionStatus;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.ActiveJobState:
                {
                    if (createOrReplace)
                    {
                        if (ActiveJobState == null)
                        {
                            if (replacement == null)
                            {
                                ActiveJobState = new PropertyState<int>(this);
                            }
                            else
                            {
                                ActiveJobState = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = ActiveJobState;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.JobList:
                {
                    if (createOrReplace)
                    {
                        if (JobList == null)
                        {
                            if (replacement == null)
                            {
                                JobList = new JobListState(this);
                            }
                            else
                            {
                                JobList = (JobListState)replacement;
                            }
                        }
                    }

                    instance = JobList;
                    break;
                }

                case Quickstarts.FakraOpc.BrowseNames.ArticleList:
                {
                    if (createOrReplace)
                    {
                        if (ArticleList == null)
                        {
                            if (replacement == null)
                            {
                                ArticleList = new ArticleListState(this);
                            }
                            else
                            {
                                ArticleList = (ArticleListState)replacement;
                            }
                        }
                    }

                    instance = ArticleList;
                    break;
                }

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

                case Quickstarts.FakraOpc.BrowseNames.ActivateJob:
                {
                    if (createOrReplace)
                    {
                        if (ActivateJob == null)
                        {
                            if (replacement == null)
                            {
                                ActivateJob = new ActivateJobMethodState(this);
                            }
                            else
                            {
                                ActivateJob = (ActivateJobMethodState)replacement;
                            }
                        }
                    }

                    instance = ActivateJob;
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
                                GenerateReport = new GenerateReportMethodState(this);
                            }
                            else
                            {
                                GenerateReport = (GenerateReportMethodState)replacement;
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
        private PropertyState<int> m_productionStatus;
        private PropertyState<int> m_activeJobState;
        private JobListState m_jobList;
        private ArticleListState m_articleList;
        private AddJobMethodState m_addJobMethod;
        private ActivateJobMethodState m_activateJobMethod;
        private DeleteJobMethodState m_deleteJobMethod;
        private GenerateReportMethodState m_generateReportMethod;
        #endregion
    }
    #endif
    #endregion

    #region SystemCycleStatusEventState Class
    #if (!OPCUA_EXCLUDE_SystemCycleStatusEventState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class SystemCycleStatusEventState : SystemEventState
    {
        #region Constructors
        public SystemCycleStatusEventState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.SystemCycleStatusEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

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
        public PropertyState<string> CycleId
        {
            get => m_cycleId;

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
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_cycleId, child))
            {
                m_cycleId = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class WireFinishedEventState : BaseEventState
    {
        #region Constructors
        public WireFinishedEventState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.WireFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

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
        public PropertyState<uint> JobId
        {
            get => m_jobId;

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        public PropertyState<uint> BatchSequenceNumber
        {
            get => m_batchSequenceNumber;

            set
            {
                if (!Object.ReferenceEquals(m_batchSequenceNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_batchSequenceNumber = value;
            }
        }

        public PropertyState<uint> WireSequenceNumber
        {
            get => m_wireSequenceNumber;

            set
            {
                if (!Object.ReferenceEquals(m_wireSequenceNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wireSequenceNumber = value;
            }
        }

        public PropertyState<uint> GoodPartCount
        {
            get => m_goodPartCount;

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        public PropertyState<uint> BadPartCount
        {
            get => m_badPartCount;

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
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_jobId, child))
            {
                m_jobId = null;
                return;
            }

            if (Object.ReferenceEquals(m_batchSequenceNumber, child))
            {
                m_batchSequenceNumber = null;
                return;
            }

            if (Object.ReferenceEquals(m_wireSequenceNumber, child))
            {
                m_wireSequenceNumber = null;
                return;
            }

            if (Object.ReferenceEquals(m_goodPartCount, child))
            {
                m_goodPartCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_badPartCount, child))
            {
                m_badPartCount = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class BatchFinishedEventState : BaseEventState
    {
        #region Constructors
        public BatchFinishedEventState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.BatchFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

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
        public PropertyState<uint> BatchSequenceNumber
        {
            get => m_batchSequenceNumber;

            set
            {
                if (!Object.ReferenceEquals(m_batchSequenceNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_batchSequenceNumber = value;
            }
        }

        public PropertyState<uint> JobId
        {
            get => m_jobId;

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        public PropertyState<uint> GoodPartCount
        {
            get => m_goodPartCount;

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        public PropertyState<uint> BadPartCount
        {
            get => m_badPartCount;

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
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_batchSequenceNumber, child))
            {
                m_batchSequenceNumber = null;
                return;
            }

            if (Object.ReferenceEquals(m_jobId, child))
            {
                m_jobId = null;
                return;
            }

            if (Object.ReferenceEquals(m_goodPartCount, child))
            {
                m_goodPartCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_badPartCount, child))
            {
                m_badPartCount = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class JobFinishedEventState : BaseEventState
    {
        #region Constructors
        public JobFinishedEventState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.JobFinishedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

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
        public PropertyState<uint> JobId
        {
            get => m_jobId;

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        public PropertyState<uint> GoodPartCount
        {
            get => m_goodPartCount;

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        public PropertyState<uint> BadPartCount
        {
            get => m_badPartCount;

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
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_jobId, child))
            {
                m_jobId = null;
                return;
            }

            if (Object.ReferenceEquals(m_goodPartCount, child))
            {
                m_goodPartCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_badPartCount, child))
            {
                m_badPartCount = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class JobStoppedEventState : BaseEventState
    {
        #region Constructors
        public JobStoppedEventState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.JobStoppedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

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
        public PropertyState<uint> JobId
        {
            get => m_jobId;

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        public PropertyState<uint> GoodPartCount
        {
            get => m_goodPartCount;

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        public PropertyState<uint> BadPartCount
        {
            get => m_badPartCount;

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
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_jobId, child))
            {
                m_jobId = null;
                return;
            }

            if (Object.ReferenceEquals(m_goodPartCount, child))
            {
                m_goodPartCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_badPartCount, child))
            {
                m_badPartCount = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ProductionStartedEventState : BaseEventState
    {
        #region Constructors
        public ProductionStartedEventState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.ProductionStartedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

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
        public PropertyState<uint> JobId
        {
            get => m_jobId;

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        public PropertyState<uint> GoodPartCount
        {
            get => m_goodPartCount;

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        public PropertyState<uint> BadPartCount
        {
            get => m_badPartCount;

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
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_jobId, child))
            {
                m_jobId = null;
                return;
            }

            if (Object.ReferenceEquals(m_goodPartCount, child))
            {
                m_goodPartCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_badPartCount, child))
            {
                m_badPartCount = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ProductionStoppedEventState : BaseEventState
    {
        #region Constructors
        public ProductionStoppedEventState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Quickstarts.FakraOpc.ObjectTypes.ProductionStoppedEventType, Quickstarts.FakraOpc.Namespaces.FakraOpc, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

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
        public PropertyState<uint> JobId
        {
            get => m_jobId;

            set
            {
                if (!Object.ReferenceEquals(m_jobId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobId = value;
            }
        }

        public PropertyState<uint> GoodPartCount
        {
            get => m_goodPartCount;

            set
            {
                if (!Object.ReferenceEquals(m_goodPartCount, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_goodPartCount = value;
            }
        }

        public PropertyState<uint> BadPartCount
        {
            get => m_badPartCount;

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
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_jobId, child))
            {
                m_jobId = null;
                return;
            }

            if (Object.ReferenceEquals(m_goodPartCount, child))
            {
                m_goodPartCount = null;
                return;
            }

            if (Object.ReferenceEquals(m_badPartCount, child))
            {
                m_badPartCount = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

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