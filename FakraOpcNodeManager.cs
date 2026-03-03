using Opc.Ua;
using Opc.Ua.Server;
using System.Reflection;

namespace WebApiOpcServer
{
    public class FakraOpcNodeManager : CustomNodeManager2
    {
        private FakraOpcServerConfiguration m_configuration;
        private Quickstarts.FakraOpc.MachineState m_machine;

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

                // TODO: load articles from database or configuration
                // AddArticle(m_machine.ArticleList, 100, "Heta520-P26", "Heta520-P26", true);
                AddArticle(m_machine.ArticleList, 200, "547-D-F-F-0.13", "547-D-F-F-0.13", true);
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
        /// Returns a unique handle for the node.
        /// </summary>
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

        /// <summary>
        /// Verifies that the specified node exists.
        /// </summary>
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
