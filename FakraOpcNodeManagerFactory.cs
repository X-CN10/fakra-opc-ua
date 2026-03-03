using Opc.Ua.Server;
using Opc.Ua;

namespace WebApiOpcServer
{
    public class FakraOpcNodeManagerFactory : INodeManagerFactory
    {
        public FakraOpcNodeManager? NodeManager { get; private set; }
        
        //public StringCollection NamespacesUris => new StringCollection() { "http://opcfoundation.org/OpcUaServer" };
        public StringCollection NamespacesUris => new StringCollection() { "http://schleuniger.com/Default/" };

        public INodeManager Create(IServerInternal server, ApplicationConfiguration configuration)
        {
            if (NodeManager != null)
                return NodeManager;

            NodeManager = new FakraOpcNodeManager(server, configuration, NamespacesUris.ToArray());
            return NodeManager;
        }
    }
}
