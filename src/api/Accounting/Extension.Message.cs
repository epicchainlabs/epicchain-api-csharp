using Google.Protobuf;
using EpicChain.API.v2.Session;

namespace EpicChain.API.v2.Accounting
{
    public partial class BalanceRequest : IRequest
    {
        public IMessage GetBody()
        {
            return Body;
        }
    }

    public partial class BalanceResponse : IResponse
    {
        public IMessage GetBody()
        {
            return Body;
        }
    }
}
