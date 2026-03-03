using Opc.Ua;
using Opc.Ua.Server;
using System.Reflection;

namespace WebApiOpcServer
{
    public class FakraOpcNodeManager : CustomNodeManager2
    {
        private FakraOpcServerConfiguration m_configuration;
        private Quickstarts.FakraOpc.MachineState m_machine;

        public Quickstarts.FakraOpc.MachineState Machine => m_machine;

        public FakraOpcNodeManager(IServerInternal server, ApplicationConfiguration configuration, params string[] namespaceUris)
            : base(server, configuration, namespaceUris)
        {
            SystemContext.NodeIdFactory = this;

            string[] namespaceUrls = new string[1];
            namespaceUrls[0] = Quickstarts.FakraOpc.Namespaces.FakraOpc;
            SetNamespaces(namespaceUrls);

            m_configuration = configuration.ParseExtension<FakraOpcServerConfiguration>();

            if (m_configuration == null)
            {
                m_configuration = new FakraOpcServerConfiguration();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public override NodeId New(ISystemContext context, NodeState node)
        {
            return node.NodeId;
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "ModelDesign\\Quickstarts.FakraOpc.PredefinedNodes.uanodes",
                typeof(FakraOpcNodeManager).GetTypeInfo().Assembly,
                true);
            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                NodeState root = FindNodeInAddressSpace(new NodeId(Opc.Ua.ObjectIds.ObjectsFolder));

                m_machine = new Quickstarts.FakraOpc.MachineState(null);
                m_machine.Create(
                    SystemContext,
                    new NodeId("Machine", NamespaceIndex),
                    new QualifiedName("Machine", NamespaceIndex),
                    null,
                    true);

                m_machine.AddReference(Opc.Ua.ReferenceTypeIds.Organizes, true, root.NodeId);
                root.AddReference(Opc.Ua.ReferenceTypeIds.Organizes, false, m_machine.NodeId);
                AddPredefinedNode(SystemContext, m_machine);

                m_machine.SetNodeManager(this);

                // TODO: load articles from database or configuration
                AddArticle(m_machine.ArticleList, 300, "Heta520-P26", "Heta520-P26", true);
            }
        }

        /// <summary>
        /// Adds an article node under the given ArticleList container.
        /// </summary>
        public Quickstarts.FakraOpc.ArticleState AddArticle(
            Quickstarts.FakraOpc.ArticleListState articleList,
            uint articleId,
            string articleName,
            string articleNumber,
            bool canBeProduced)
        {
            var article = new Quickstarts.FakraOpc.ArticleState(null);

            article.Create(
                SystemContext,
                new NodeId($"Article_{articleId}", NamespaceIndex),
                new QualifiedName($"Article_{articleId}", NamespaceIndex),
                null,
                true);

            article.ArticleId.Value = articleId;
            article.ArticleName.Value = articleName;
            article.ArticleNumber.Value = articleNumber;
            article.CanBeProduced.Value = canBeProduced;

            articleList.AddReference(ReferenceTypeIds.HasComponent, false, article.NodeId);
            article.AddReference(ReferenceTypeIds.HasComponent, true, articleList.NodeId);

            AddPredefinedNode(SystemContext, article);
            return article;
        }

        /// <summary>
        /// Checks whether an article with the given ID exists in the address space.
        /// </summary>
        public bool ArticleExists(uint articleId)
        {
            lock (Lock)
            {
                var nodeId = new NodeId($"Article_{articleId}", NamespaceIndex);
                return PredefinedNodes != null && PredefinedNodes.ContainsKey(nodeId);
            }
        }

        /// <summary>
        /// Creates a new Job node under the JobList in the OPC UA address space.
        /// </summary>
        public Quickstarts.FakraOpc.JobInfoState AddJob(
            Quickstarts.FakraOpc.JobListState jobList,
            uint jobId,
            string jobName,
            uint jobQuantity,
            uint batchQuantity,
            uint articleId)
        {
            lock (Lock)
            {
                var job = new Quickstarts.FakraOpc.JobInfoState(jobList);

                job.Create(
                    SystemContext,
                    new NodeId($"Job_{jobId}", NamespaceIndex),
                    new QualifiedName($"Job_{jobId}", NamespaceIndex),
                    null,
                    true);

                job.JobId.Value = jobId;
                job.JobName.Value = jobName;
                job.JobQuantity.Value = jobQuantity;
                job.BatchQuantity.Value = batchQuantity;
                job.ArticleId.Value = articleId;
                job.GoodPartCount.Value = 0;
                job.BadPartCount.Value = 0;
                job.BatchCount.Value = 0;
                job.JobState.Value = 0; // Initial

                AddPredefinedNode(SystemContext, job);
                return job;
            }
        }

        /// <summary>
        /// Finds an existing Job node by its JobId.
        /// </summary>
        public Quickstarts.FakraOpc.JobInfoState FindJob(uint jobId)
        {
            lock (Lock)
            {
                var nodeId = new NodeId($"Job_{jobId}", NamespaceIndex);
                if (PredefinedNodes != null && PredefinedNodes.TryGetValue(nodeId, out var node))
                {
                    return node as Quickstarts.FakraOpc.JobInfoState;
                }
                return null;
            }
        }

        /// <summary>
        /// Removes a Job node and its children from the address space.
        /// </summary>
        public bool RemoveJob(uint jobId)
        {
            lock (Lock)
            {
                var nodeId = new NodeId($"Job_{jobId}", NamespaceIndex);
                if (PredefinedNodes == null || !PredefinedNodes.TryGetValue(nodeId, out var node))
                {
                    return false;
                }

                var children = new List<BaseInstanceState>();
                node.GetChildren(SystemContext, children);
                foreach (var child in children)
                {
                    if (child.NodeId != null)
                    {
                        PredefinedNodes.Remove(child.NodeId);
                    }
                }

                PredefinedNodes.Remove(nodeId);
                return true;
            }
        }

        protected override NodeHandle GetManagerHandle(ServerSystemContext context, NodeId nodeId, IDictionary<NodeId, NodeState> cache)
        {
            lock (Lock)
            {
                if (!IsNodeIdInNamespace(nodeId))
                {
                    return null;
                }
                if (PredefinedNodes != null)
                {
                    NodeState node = null;

                    if (PredefinedNodes.TryGetValue(nodeId, out node))
                    {
                        NodeHandle handle = new NodeHandle();

                        handle.NodeId = nodeId;
                        handle.Validated = true;
                        handle.Node = node;

                        return handle;
                    }
                }
                return null;
            }
        }

        protected override NodeState ValidateNode(
            ServerSystemContext context,
            NodeHandle handle,
            IDictionary<NodeId, NodeState> cache)
        {
            if (handle == null)
            {
                return null;
            }
            if (handle.Validated)
            {
                return handle.Node;
            }
            return null;
        }
    }
}
