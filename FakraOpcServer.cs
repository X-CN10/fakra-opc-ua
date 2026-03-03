using Opc.Ua;
using Opc.Ua.Server;

namespace WebApiOpcServer
{
    public class FakraOpcServer : StandardServer
    {

        //protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        //{
        //    List<INodeManager> nodeManagers = new List<INodeManager>();
        //    nodeManagers.Add(new FakraOpcNodeManager(server, configuration));
        //    return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        //}
    }
}
