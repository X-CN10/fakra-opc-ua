using Microsoft.Extensions.Configuration;
using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Reflection;

namespace WebApiOpcServer
{
    public class FakraOpcNodeManager : CustomNodeManager2
    {
        private FakraOpcServerConfiguration m_configuration;
        public FakraOpcNodeManager(IServerInternal server, ApplicationConfiguration configuration ,params string[] namespaceUris)
            :base(server, configuration, namespaceUris)
        {
            SystemContext.NodeIdFactory = this;

            string[] namespaceUrls = new string[1];
            namespaceUrls[0] = Quickstarts.FakraOpc.Namespaces.FakraOpc;
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<FakraOpcServerConfiguration>();

            // use suitable defaults if no configuration exists.
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
                //查找根节点
                NodeState root = FindNodeInAddressSpace(new NodeId(Opc.Ua.ObjectIds.ObjectsFolder));
                var boiler1 = new Quickstarts.FakraOpc.MachineState(null);
                //ParsedNodeId pnd1 = new ParsedNodeId() { NamespaceIndex = NamespaceIndex, RootId = "Machine" };
                boiler1.Create(
                    SystemContext,
                    //pnd1.Construct(),
                    new NodeId("Machine", NamespaceIndex),
                    new QualifiedName("Machine", NamespaceIndex),
                    null,
                    true);

                boiler1.AddReference(Opc.Ua.ReferenceTypeIds.Organizes, true, root.NodeId);

                root.AddReference(Opc.Ua.ReferenceTypeIds.Organizes, false, boiler1.NodeId);

                AddPredefinedNode(SystemContext, boiler1);
            }
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
