using EpicChainAPI.v2.Session;
using Google.Protobuf;

namespace EpicChainAPI.v2.Session
{
    public interface IRequestMeta
    {
        RequestMetaHeader MetaHeader { get; set; }
    }

    public interface IRequest : IRequestMeta
    {
        RequestVerificationHeader VerifyHeader { get; set; }
        IMessage GetBody();
    }
}