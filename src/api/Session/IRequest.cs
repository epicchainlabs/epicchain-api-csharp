using EpicChain.API.v2.Session;
using Google.Protobuf;

namespace EpicChain.API.v2.Session
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