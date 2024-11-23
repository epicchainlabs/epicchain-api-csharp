using Google.Protobuf;
using EpicChainAPI.v2.Session;

namespace EpicChainAPI.v2.Netmap
{
    public partial class LocalNodeInfoRequest : IRequest
    {
        public IMessage GetBody()
        {
            return Body;
        }
    }

    public partial class LocalNodeInfoResponse : IResponse
    {
        public IMessage GetBody()
        {
            return Body;
        }
    }
}
